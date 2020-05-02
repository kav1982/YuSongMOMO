using UnityEditor;
using UnityEngine;

public class Script_03_06 
{
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod()
    {
        //instanceID：场景中物体的唯一标识
        //selectionRect：Rect代表矩形区域
        EditorApplication.hierarchyWindowItemOnGUI = delegate (int instanceID, Rect selectionRect)
        {
            //如果点击的物体ID和场景中激活的物体ID一致
            if (Selection.activeObject && instanceID == Selection.activeObject.GetInstanceID())
            {
                float width = 50f;
                float height = 20f;
                selectionRect.x += (selectionRect.width - width);
                selectionRect.width = width;
                selectionRect.height = height;

                //GUIContent类下的IconContent方法，取系统的图片路径
                if (GUI.Button(selectionRect, EditorGUIUtility.IconContent("SceneAsset Icon")))
                {
                    Debug.LogFormat("click : {0}", Selection.activeObject.name);
                }
            }
        };
    }
}
