using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardButton : MonoBehaviour {
    public Button button;
    public Text nameText;
    public Text costText;
    public Text typeText;
    public Text bodyText;
    public Card card;
    private Player owner;

    // Use this for initialization
    void Start () {
        button.onClick.AddListener(PlayCard);
    }
    public void Setup(Card c, Player player) {
        nameText.text = c.name;
        costText.text = c.energyCost.ToString();
        typeText.text = c.cardType.ToString();
        bodyText.text = c.GetText();
        card = c;
        owner = player;
    }
    public void PlayCard() {
        owner.PlayCard(card);
    }
}
