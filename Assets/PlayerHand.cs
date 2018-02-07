using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour {
    public SimpleObjectPool cardObjectPool;
    public Player player;
    public void Add(Card card) {
        GameObject newButtonObject = cardObjectPool.GetObject();
        CardButton cardButton = newButtonObject.GetComponent<CardButton>();
        cardButton.Setup(card, player);
        newButtonObject.transform.SetParent(gameObject.transform);
    }
    public void Remove(Card card) {
        GameObject uiButton;
        for (int pc = 0; pc < transform.childCount; pc++) {
            uiButton = transform.GetChild(pc).gameObject;
            if (uiButton.GetComponent<CardButton>().card.GetInstanceID() == card.GetInstanceID()) {
                cardObjectPool.ReturnObject(uiButton);
                break;
            }
        }
    }
    public void Empty() {
        while (transform.childCount > 0) {
            cardObjectPool.ReturnObject(transform.GetChild(0).gameObject);
        }
    }
}
