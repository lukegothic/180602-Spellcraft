using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public Effect[] effects;
    public int currentHP;
    public int maxHP;
    public int gold;
    public Text hpText;
    public Card[] deck;

    // Use this for initialization
    void Start () {
        gold = Random.Range(Mathf.RoundToInt(currentHP * 0.5f), Mathf.RoundToInt(currentHP * 1.5f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void LateUpdate() {
        hpText.text = currentHP.ToString();
    }
}
