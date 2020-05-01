using UnityEditor;
using UnityEngine;

public class Script_03_05 : MonoBehaviour
{
    [MenuItem("GameObject/My Create/Cube",false, 0)]
    static void CreateCube()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}
