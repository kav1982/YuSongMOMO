using UnityEditor;
using UnityEngine;

public class Script_03_20 
{
    [MenuItem("Root/Test0", false,1)]
    static void Test1()
    {

    }

    [MenuItem("Root/Test0", false,0)]
    static void Test0()
    {

    }

    [MenuItem("Root/Test/2")]
    static void Test2()
    {

    }

    [MenuItem("Root/Test/2", true,20)]
    static bool Test2Validation()
    {
    	return false;
    }

    [MenuItem("Root/Test3", false,3)]
    static void Test3()
    {
    	var menuPath = "Root/Test3";
    	bool mchecked = Menu.GetChecked(menuPath);
    	Menu.SetChecked(menuPath, !mchecked);
    }
}
