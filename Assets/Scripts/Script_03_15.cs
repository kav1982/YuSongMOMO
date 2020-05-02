using UnityEngine;

public class Script_03_15 : MonoBehaviour
{
     void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, Vector3.one);
        Gizmos.DrawCube(Vector3.one, Vector3.one);
        //Debug.DrawRay(new Vector3(0, 0, 0), new Vector3(1, 0, 0), Color.red);
    }

    //不依赖选择对象始终出现
     void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, 1);
        //DrawRay划线，从原点沿着X轴向画一条长度10的红线
        Debug.DrawRay(new Vector3(0, 0, 0), new Vector3(10, 0, 0), Color.red);
    }
}
