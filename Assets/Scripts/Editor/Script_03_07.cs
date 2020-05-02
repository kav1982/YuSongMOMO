using UnityEditor;
using UnityEngine;

public class Script_03_07 
{
    [MenuItem("Window/Test/yusong")]
    static void Test()
    {

    }

    [MenuItem("Window/Test/momo")]
    static void Test1()
    {

    }

    [MenuItem("Window/Test/雨凇/MOMO")]
    static void Test2()
    {

    }

    [InitializeOnLoadMethod]
    static void StartInitializeOnLoadMethod()
    {
        //hierarchyWindowItemOnGUI：委派HierarchyWindow中每个可见列表项的OnGUI事件
        //Hierarchy 层次结构
        EditorApplication.hierarchyWindowItemOnGUI += OnHierarchyGUI;
    }

    static void OnHierarchyGUI(int instanceID, Rect selectionRect)
    {
        //1.current 不等于空（发生了点击）
        //2.获取到鼠标的位置在Rect范围内
        //3.屏幕上Rect位置的组件是否被按下
        //4.触发事件的类型是否是鼠标
        if(Event.current != null && selectionRect.Contains(Event.current.mousePosition) 
            && Event.current.button == 1 && Event.current.type <= EventType.MouseUp)
        {
            GameObject selectedGameObject = EditorUtility.InstanceIDToObject(instanceID) as GameObject;
            //判断选择物体的条件
            if(selectedGameObject)
            {
                //DisplayPopupMenu 显示一个弹出菜单
                Vector2 mousePosition = Event.current.mousePosition;
                EditorUtility.DisplayPopupMenu(new Rect(mousePosition.x, mousePosition.y, 0, 0), "Window/Test", null);
                Event.current.Use();
            }
        }
    }
}
