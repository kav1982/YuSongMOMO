using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Camera))]

public class Script_03_09 : Editor
{
    public override void OnInspectorGUI()
    {
        if(GUILayout.Button("拓展按钮"))
        {
            base.OnInspectorGUI();
        }
    }
}
