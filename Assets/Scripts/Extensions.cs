using System.Collections.Generic;
using UnityEngine;

public static class Extensions {
    public static void shuffle<T>(this List<T> array) {
        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int t = 0; t < array.Count; t++) {
            T tmp = array[t];
            int r = Random.Range(t, array.Count);
            array[t] = array[r];
            array[r] = tmp;
        }
    }
    public static T PopAt<T>(this List<T> list, int idx) {
        T r = list[idx];
        list.RemoveAt(idx);
        return r;
    }
    public static T Pop<T>(this List<T> list) {
        return list.PopAt(list.Count - 1);
    }
}
