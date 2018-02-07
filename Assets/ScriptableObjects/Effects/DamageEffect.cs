using UnityEngine;

[System.Serializable]
[CreateAssetMenu]
public class DamageEffect : Effect2 {
    public int amount;
    public override void Apply(GameObject target) {
        target.GetComponent<Health>().Damage(amount);
    }
}
