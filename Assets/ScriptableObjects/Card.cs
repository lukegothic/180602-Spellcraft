using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum CardType {
    Attack,
    Skill,
    Power
}
[CreateAssetMenu(fileName = "CardNew", menuName = "Create a new card")]
public class Card : ScriptableObject {
    public new string name;
    public int energyCost;
    public bool isUpgraded;
    public CardType cardType;
    public Effect[] basicEffects;
    public Effect[] upgradedEffects;

    public string GetText() {
        string text = "";
        foreach (Effect effect in (isUpgraded ? upgradedEffects : basicEffects)) {
            text += effect.ToString();
            text += "\n";
        }
        return text;
    }
    public void Play() {
        switch (cardType) {
            case CardType.Attack:
                break;
            case CardType.Skill:
                break;
            case CardType.Power:
                Player.instance.powers.AddRange(isUpgraded ? upgradedEffects : basicEffects);
                break;
            default:
                break;
        }
        Debug.Log("me juegan");
    }
}
