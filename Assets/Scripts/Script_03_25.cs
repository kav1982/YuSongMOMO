using UnityEditor;
using UnityEngine;

public class Script_03_25 : EditorWindow, IHasCustomMenu
{
    void IHasCustomMenu.AddItemsToMenu(GenericMenu menu)
    {
        menu.AddDisabledItem(new GUIContent("Disable"));
        menu.AddItem(new GUIContent("Test1"), true, () =>
        {
            Debug.Log("Test1");
        });
        menu.AddItem(new GUIContent("Test2"), true, () =>
        {
            Debug.Log("Test2");
        });
        menu.AddSeparator("Test/");
        menu.AddItem(new GUIContent("Test/Tes3"), true, () =>
        {
            Debug.Log("Test3");
        });

    }

    [MenuItem("Window/Open My Window_1")]
    static void Init()
    {
        Script_03_25 window = (Script_03_25)EditorWindow.GetWindow(typeof(Script_03_25));
        window.Show();
    }
}
