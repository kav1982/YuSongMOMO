using UnityEditor;
using UnityEngine;

public class Script_03_21 
{
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod()
    {
    	SceneView.duringSceneGui += delegate(SceneView sceneView)
        // 事件的好处：解决多播委托的数据不同步问题
        // 1.有条件的触发
        // 2.保护委托的内容不在其它地方被修改
        {
            Event e = Event.current;

            //当鼠标右键抬起
    		if(e != null && e.button == 1 && e.type == EventType.MouseUp)
    		{
    			Vector2 mousePosition = e.mousePosition;
    			//设置菜单
    			var options = new GUIContent[]
    			{
    				new GUIContent("Test1"),
    				new GUIContent("Test2"),
    				new GUIContent(""),
    				new GUIContent("Test/Test3"),
    				new GUIContent("Test/Test4"),
    			};

                //设置菜单显示区域
    			var selected = -1;
    			var userData = Selection.activeGameObject;
    			var width = 100;
    			var height = 100;
    			var position = new Rect(mousePosition.x, mousePosition.y - height, width, height);

                //显示菜单
                // DisplayCustomMenu(Rect position, GUIContent[] options, int selected, SelectMenuItemFunction callback, object userData);
                //EditorUtility.DisplayCustomMenu(position, options, selected,
                //delegate (object data, string[] opt, int select)
                //{
                //    Debug.Log(opt[select]);
                //},userData); 
                EditorUtility.DisplayCustomMenu(position, options, selected,( data, opt, select) =>{Debug.Log(opt[select]);}, userData);

                //使用这个事件
    			e.Use();
    		}
    	};
    }
}
