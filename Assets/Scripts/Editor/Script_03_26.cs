using UnityEditor;
using UnityEngine;

[CustomPreview(typeof(GameObject))]
public class Script_03_26 : ObjectPreview
{
    public override bool HasPreviewGUI( )
    {
        return true;
    }

    public override void OnPreviewGUI(Rect r, GUIStyle background)
    {
        GUI.DrawTexture(r, AssetDatabase.LoadAssetAtPath<Texture>("Assets/unity.png"));
        GUILayout.Label("Hello World!!!");
    }
}


