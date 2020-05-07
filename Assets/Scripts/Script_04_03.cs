using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_03 : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake 用于初始化并且永远只会执行一次");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable 在脚本每次激活时执行一次");
    }

    void Start()
    {
        Debug.Log("Start 在初始化侯的下一帧执行，并且永远只会执行一次");        
    }

    void OnDisable()
    {
        Debug.Log("OnDisable 在脚本每次反激活后，执行一次");
    }

    void OnApplicationQuit()
    {
        Debug.Log("应用程序退出时执行一次");
    }

}
