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
        //如何转换为系统图标？？？
        GUI.DrawTexture(r, EditorGUIUtility.IconContent("SceneAsset Icon").image);
        GUILayout.Label("Hello World!!!");
    }
}


