using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_04 : MonoBehaviour
{
    void Satrt()
    {
        StartCoroutine(CreateCube());
    }
    IEnumerator CreateCube()
    {
        for(int i=0; i<100; i++)
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = Vector3.one * i;
            //等待一秒再执行下一个循环
            yield return new WaitForSeconds(1f);
        }
    }
}
