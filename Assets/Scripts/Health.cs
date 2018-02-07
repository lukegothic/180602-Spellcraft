using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public int current;
    public int max;
	void Start () {
        current = max;
	}
	void Update () {
	    // msotrar vida
	}
    public void Damage(int amount) {
        current = Mathf.Max(current - amount, 0);
        if (current == 0) {
            DestroyImmediate(gameObject);
        }
    }
}
