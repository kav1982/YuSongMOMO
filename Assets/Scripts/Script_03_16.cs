using System.Collections;
using UnityEditor;
using UnityEngine;

public class Script_03_16 : Editor
{
    void OnSceneGUI( )
    {
        Camera camera = target as Camera;
        if(camera != null)
        {
            Handles.color = Color.red;
            Handles.Label(camera.transform.position, camera.transform.position.ToString( ));

            Handles.BeginGUI( );
            GUI.backgroundColor = Color.red;
            if(GUILayout.Button("Click",GUILayout.Width(200f)))
            {
                Debug.LogFormat("click = {0}", camera.name);
            }
            GUILayout.Label("Label");
            Handles.EndGUI( );


        }
    }
}
