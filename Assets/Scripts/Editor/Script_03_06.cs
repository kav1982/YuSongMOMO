using UnityEditor;
using UnityEngine;

public class Script_03_06 
{
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod()
    {
        EditorApplication.hierarchyWindowItemOnGUI = delegate (int instanceID, Rect selectionRect)
        {
            if (Selection.activeObject && instanceID == Selection.activeObject.GetInstanceID())
            {
                float width = 50f;
                float height = 20f;
                selectionRect.x += (selectionRect.width - width);
                selectionRect.width = width;
                selectionRect.height = height;

                if (GUI.Button(selectionRect, AssetDatabase.LoadAssetAtPath<Texture>("Assets/unity.png")))
                {
                    Debug.LogFormat("click : {0}", Selection.activeObject.name);
                }
            }
        };
    }
}
