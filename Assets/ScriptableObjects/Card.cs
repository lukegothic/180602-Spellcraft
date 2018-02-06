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
}
