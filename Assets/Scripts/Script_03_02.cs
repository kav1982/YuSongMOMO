using UnityEditor;
using UnityEngine;

public class Script_03_02 
{
    [MenuItem("Assets/Create/My Create/cube", false, 2)]
    static void CreateCube()
    {
        //CreatePrimitive:创建原始类型的对象
        GameObject.CreatePrimitive(PrimitiveType.Cube); //创建立方体
    }
    [MenuItem("Assets/Create/My Create/Sphere", false, 1)]
    static void CreateSphere( )
    {
        GameObject.CreatePrimitive(PrimitiveType.Sphere); //创建球体
    }
}
