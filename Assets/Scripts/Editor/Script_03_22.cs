using UnityEditor;
using UnityEngine;

public class Script_03_22 : MonoBehaviour
{
    [MenuItem("Assets/HotKey %#d", false, -1)]
    private static void Hotkey()
    {
    	Debug.Log("Command Shift + D");
    }
}
