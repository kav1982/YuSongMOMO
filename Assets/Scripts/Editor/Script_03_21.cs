using UnityEditor;
using UnityEngine;

public class Script_03_21 
{
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod()
    {
    	SceneView.duringSceneGui += delegate(SceneView sceneView)
    	{
    		Event e = Event.current;
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

    			var selected = -1;
    			var userData = Selection.activeGameObject;
    			var width = 100;
    			var height = 100;
    			var position = new Rect(mousePosition.x, mousePosition.y - height, width, height);

    			EditorUtility.DisplayCustomMenu(position, options, selected,
    				delegate(object data, string[] opt, int select)
    				{
    					Debug.Log(opt[select]);
    				},
    				userData);
    				e.Use();
    		}
    	};
    }
}
