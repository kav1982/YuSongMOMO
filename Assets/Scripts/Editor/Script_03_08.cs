using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Script_03_08 
{
    [MenuItem("GameObject/UI/Image")]
    static void CreatImage()
    {
        if(Selection.activeTransform)
        {
            //Canvas UI的画布
            if (Selection.activeTransform.GetComponentInParent<Canvas>())
            {
                Image image = new GameObject("image").AddComponent<Image>();
                image.raycastTarget = false;
                //raycastTarget 游戏运行时不要向点击的目标发射射线
                image.transform.SetParent(Selection.activeTransform, false);
            }
        }
    }
}
