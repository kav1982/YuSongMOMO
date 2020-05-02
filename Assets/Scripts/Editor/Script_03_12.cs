﻿using UnityEditor;
using UnityEngine;

public class Script_03_12 
{
    [MenuItem("GameObject/3D Object/Lock/Lock", false, 0)]
    static void Lock()
    {
        if(Selection.gameObjects != null)
        {
            foreach(var gameObject in Selection.gameObjects)
            {
                // HideFlags: Bit mask that controls object destruction, saving and visibility in inspectors.
                gameObject.hideFlags = HideFlags.NotEditable;
            }
        }
    }
    [MenuItem("GameObject/3D Object/Lock/UnLock",false, 1)]
    static void UnLock()
    {
        if(Selection.gameObjects != null)
        {
            foreach(var gameObject in Selection.gameObjects)
            {
                gameObject.hideFlags = HideFlags.None;
            }
        }
    }
}
