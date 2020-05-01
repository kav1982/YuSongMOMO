using UnityEngine;

public class Script_03_15 : MonoBehaviour
{
     void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, Vector3.one);
        Gizmos.DrawCube(Vector3.one, Vector3.one);
    }

     void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, 1);
    }
}
