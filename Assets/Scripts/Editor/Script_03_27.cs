using UnityEditor;
using UnityEngine;

public class Script_03_27 : EditorWindow
{
    private GameObject m_MyGo;
    private Editor m_MyEditor;

    [MenuItem("Window/Open My Window(Show)")]
    static void Init()
    {
        Script_03_27 window = (Script_03_27)EditorWindow.GetWindow(typeof(Script_03_27));
        window.Show();
    }
    void OnGUI()
    {
        m_MyGo = (GameObject)EditorGUILayout.ObjectField(m_MyGo, typeof(GameObject), true); 
        if(m_MyGo != null)
        {
            if(m_MyEditor == null)
            {
                m_MyEditor = Editor.CreateEditor(m_MyGo);
            }
            m_MyEditor.OnPreviewGUI(GUILayoutUtility.GetRect(500, 500), EditorStyles.whiteLabel);
        }
    }
}
