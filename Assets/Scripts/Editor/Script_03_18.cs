using UnityEditor;
using UnityEngine;

public class Script_03_18
{
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod()
    {
        //SceneView.onSceneGUIDelegate = delegate(SceneView sceneView)
        SceneView.duringSceneGui += delegate (SceneView sceneView)
        {
            Event e = Event.current;
            if (e != null)
            {
                int controlID = GUIUtility.GetControlID(FocusType.Passive);
                if (e.type == EventType.Layout)
                {
                    HandleUtility.AddDefaultControl(controlID);
                }
            }
        };
    }
}

[SelectionBase]
public class RootScript : MonoBehaviour
{

}