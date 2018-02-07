using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// TODO: CLASS
public enum Effects {
    Weak,
    Vulnerable,
    Heal,
    Damage,
    Defense,
    Energy,
    Draw
}
public enum TargetType {
    Single,
    Multiple,
    Self
}
[System.Serializable]
public class Effect {
    public Effects effect;
    public TargetType targetType;
    public int power;
}