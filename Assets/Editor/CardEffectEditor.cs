using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Card))]
public class CardEffectEditor : Editor {
    public override void OnInspectorGUI() {
        /*MyScript script = (MyScript)target;
        script.m_Light = EditorGUILayout.ObjectField("Light", script.m_Light, typeof(ILight));
        */
        DrawDefaultInspector();
        //GUILayout.Label("This is a Label in a Custom Editor");
    }
}