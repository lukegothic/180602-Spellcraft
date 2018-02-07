using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public List<Card> deck;
    public List<Card> hand;
    public List<Card> graveyard;
    public List<Relic> relics;
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
	// Use this for initialization
	void Start () {
        deck.shuffle();
        BeginTurn();

    }
	void BeginTurn() {
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
            } else {
                Debug.Log("Tamano maximo de mano alcanzado");
                break;
            }
        }
    }
    public void EndTurn() {
        graveyard.AddRange(hand);
        hand = new List<Card>();
    }
    public void PlayCard(Card card) {

    }
	// Update is called once per frame
	void Update () {
		
	}
    private void LateUpdate() {
        hpText.text = currentHP.ToString();

    }
    public void Hola() {
        Debug.Log("Hola desdep layer");
    }
}
