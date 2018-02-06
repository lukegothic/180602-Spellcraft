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
    public int gold;
    public Text hpText;
    public Enemy target;
    public int cardDrawNumber;
	// Use this for initialization
	void Start () {
        deck.shuffle();
        BeginTurn();

    }
	void BeginTurn() {
        for (var ci = 0; ci < cardDrawNumber; ci++) {
            if (deck.Count == 0) {
                if (graveyard.Count > 0) {
                    deck = graveyard;
                    graveyard = new List<Card>();
                    deck.shuffle();
                } else {
                    break;
                }
            }
            hand.Add(deck.Pop());
        }
    }
    void EndTurn() {

    }
    void PlayCard(int idx) {

    }
	// Update is called once per frame
	void Update () {
		
	}
    private void LateUpdate() {
        hpText.text = currentHP.ToString();

    }
}
