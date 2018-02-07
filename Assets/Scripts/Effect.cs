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
    public override string ToString() {
        return string.Format("{0} {1} {2}", effect.ToString(), power.ToString(), targetType.ToString());
    }
    public virtual void Play() {
        switch (effect) {
            case Effects.Weak:
                break;
            case Effects.Vulnerable:
                break;
            case Effects.Heal:
                break;
            case Effects.Damage:
                break;
            case Effects.Defense:
                break;
            case Effects.Energy:
                break;
            case Effects.Draw:
                break;
            default:
                break;
        }
    }
}