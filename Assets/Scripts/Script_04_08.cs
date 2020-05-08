using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class Script_04_08 : MonoBehaviour
{
    [SerializeField]
    private int id;
    [SerializeField]
    private string name;
    [SerializeField]
    private GameObject prefab;
}

#if UNITY_EDITOR
[CustomEditor(typeof(Script_04_08))]
public class ScriptInsector : Editor
{
    public override void OnInspectorGUI()
    {
        //更新最新数据
        serializedObject.Update();
        //获取数据信息
        SerializedProperty property = serializedObject.FindProperty("id");
        //赋值数据
        property.intValue = EditorGUILayout.IntField("主键",property.intValue);
        //获取信息
        property = serializedObject.FindProperty("name");
        //赋值
        property.stringValue = EditorGUILayout.TextField("姓名", property.stringValue);
        //获取
        property = serializedObject.FindProperty("prefab");
        //赋值
        property.objectReferenceValue = EditorGUILayout.ObjectField("游戏对象", property.objectReferenceValue, typeof(GameObject), true);

        //保存全部数据
        serializedObject.ApplyModifiedProperties();
    }
}
#endif
