using UnityEngine;

[System.Serializable]
public abstract class Effect2 : ScriptableObject {
    public abstract void Apply(GameObject target);
}
