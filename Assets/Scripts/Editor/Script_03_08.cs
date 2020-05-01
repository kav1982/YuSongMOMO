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
            if(Selection.activeTransform.GetComponentInParent<Canvas>())
            {
                Image image = new GameObject("image").AddComponent<Image>();
                image.raycastTarget = false;
                image.transform.SetParent(Selection.activeTransform, false);
            }
        }
    }
}
