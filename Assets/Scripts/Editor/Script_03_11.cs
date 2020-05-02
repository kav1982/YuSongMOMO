//using UnityEditor;
//using UnityEngine;
//using System.Reflection;

//[CustomEditor(typeof(Transform))]
//public class Script_03_11 : Editor
//{
//    private Editor m_Editor;
//    void OnEnable()
//    {
//        //GetAssembly 获得一个类型的源数据
//        m_Editor = Editor.CreateEditor(target, Assembly.GetAssembly(typeof(Editor)).GetType("UnityEditor.TransformInspector", true));
//    }

//    public override void OnInspectorGUI()
//    {
//        if (GUILayout.Button("拓展按钮上"))
//        { }
//        GUI.enabled = false;
//        //拓展按钮上以下的组件变灰
//        m_Editor.OnInspectorGUI();
//        GUI.enabled = true;
//        //拓展按钮下以下的按钮重新启用
//        if (GUILayout.Button("拓展按钮下"))
//        { }
//    }
//}
