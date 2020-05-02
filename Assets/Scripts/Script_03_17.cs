using UnityEditor;
using UnityEngine;

public class Script_03_17
{
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod()
    {
        //SceneView.onSceneGUIDelegate = delegate(SceneView sceneView)
        SceneView.duringSceneGui += delegate (SceneView sceneView)
        {
            //处理.初始化GUI，在3D场景中显示UI
            Handles.BeginGUI();

            //创建两个新矩形Rect
            //一个是标题Label一个是Unity图案的系统方块
            GUI.Label(new Rect(0f, 0f, 50f, 15f), "标题");
            GUI.Button(new Rect(0f, 20f, 50f, 50f), EditorGUIUtility.IconContent("SceneAsset Icon"));

            Handles.EndGUI();
        };
    }
}
