using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public static Player instance = null;
    public List<Card> deck;
    public List<Card> hand;
    public List<Card> graveyard;
    public List<Card> exhaust;
    public List<Relic> relics;
    public List<Effect> powers;
    public List<Effect> effects;
    public int currentHP;
    public int maxHP;
    public int currentEnergy;
    public int maxEnergy;
    public int gold;
    public Text hpText;
    public Text energyText;
    public Enemy target;
    public int cardDrawNumber;
    public int maxHandSize;
    public PlayerHand playerHand;
    //Awake is always called before any Start functions
    void Awake() {
        //Check if instance already exists
        if (instance == null) {
            //if not, set instance to this
            instance = this;
        }
        //If instance already exists and it's not this:
        else if (instance != this) {
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        }

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

        ////Assign enemies to a new List of Enemy objects.
        //enemies = new List<Enemy>();

        ////Get a component reference to the attached BoardManager script
        //boardScript = GetComponent<BoardManager>();

        ////Call the InitGame function to initialize the first level 
        //InitGame();
    }
    void Start () {
        instance.deck.shuffle();
        BeginTurn();
    }
	void BeginTurn() {
        // Draw cards
        Card drawnCard;
        for (var ci = 0; ci < cardDrawNumber; ci++) {
            if (hand.Count < maxHandSize) {
                if (deck.Count == 0) {
                    if (graveyard.Count > 0) {
                        deck = graveyard;
                        graveyard = new List<Card>();
                        deck.shuffle();
                    } else {
                        Debug.Log("No hay mas cartas disponibles");
                        break;
                    }
                }
                drawnCard = deck.Pop();
                hand.Add(drawnCard);
                playerHand.Add(drawnCard);
            } else {
                Debug.Log("Tamano maximo de mano alcanzado");
                break;
            }
        }
        // Energy
        currentEnergy = maxEnergy;
        // Effects
        foreach (Effect effect in effects) {
            effect.power--;
            if (effect.power == 0) {
                effects.Remove(effect);
            }
        }
        // Powers
        foreach (Effect effect in powers) {
            effect.Play();
        }
    }
    public void EndTurn() {
        graveyard.AddRange(hand);
        hand = new List<Card>();
        playerHand.Empty();
        BeginTurn();
    }
    public void PlayCard(Card card) {
        if (card.energyCost <= currentEnergy) {
            currentEnergy -= card.energyCost;
            card.Play();
            MoveToZone(card, hand, graveyard); // TODO: check if card exhausts
            playerHand.Remove(card);
        }
    }
    private void MoveToZone(Card card, List<Card> origin, List<Card> destination) {
        if (origin.Contains(card)) {
            origin.Remove(card);
            destination.Add(card);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
    private void LateUpdate() {
        hpText.text = currentHP.ToString();
        energyText.text = string.Format("{0}/{1}", currentEnergy, maxEnergy);
    }
}
