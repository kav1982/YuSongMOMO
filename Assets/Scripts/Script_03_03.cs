using UnityEditor;
using UnityEngine;

public class Script_03_03 
{
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethhod()
    {
        //EditorApplication.projectWindowItemOnGUI = delegate (string guid, Rect selectionRect)
        //guid:指的是project面板中物体的.meta文件里唯一标识ID
        //selectionRect:一般指矩形面板，用来判断鼠标点击的范围是否在矩形内部
        //lambda表达式写法：
        EditorApplication.projectWindowItemOnGUI = (guid,selectionRect) =>
        {
            if(Selection.activeObject && guid == AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(Selection.activeObject)))
            {
                float width = 50f;
                selectionRect.x += (selectionRect.width - width); //从右往左减去50个像素，右侧贴边
                selectionRect.y += 2f; //使用当前获取的高度下移两个像素
                selectionRect.width = width; //矩形宽度
                GUI.color = Color.red;

                if (GUI.Button(selectionRect, "click"))
                {
                    Debug.LogFormat("<color=green> click :{0},{1:F2},{2} green</color>", Selection.activeObject.name, 4.5567,"23456");
                    //LogFormat 格式化字符串的一种形式 1:F2 1是索引 F2指打印到浮点数后的第二位
                    //<color=green> XXXXX green</color>，给log加颜色
                }
                GUI.color = Color.white;
            }
        };   
    }
}
