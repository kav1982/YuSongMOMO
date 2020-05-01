using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

public class Script_03_04 : UnityEditor.AssetModificationProcessor
{
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod( )
    {
        EditorApplication.projectChanged += delegate ()
        {
            Debug.Log("change");
        };
    }

    public static bool IsOpenForEdit(string assetPath, out string message)
    {
        message = null;
        Debug.LogFormat("assetPath:{0}", assetPath);
        return true;
    }

    public static void OnWillCreateAsset(string path)
    {
        Debug.LogFormat("path:{0}", path);
    }
    
    public static string[ ] OnWillSaveAssets(string[] paths)
    {
        if(paths != null)
        {
            Debug.LogFormat("path:{0}", string.Join(",", paths));
        }
        return paths;
    }

    public static AssetMoveResult OnWillMoveAsset(string oldPath, string newPath)
    {
        Debug.LogFormat("from:{0}to:{1}", oldPath, newPath);
        return AssetMoveResult.DidMove;
    }

    public static AssetDeleteResult OnWillDeleteAsset(string assetPath, RemoveAssetOptions option)
    {
        Debug.LogFormat("delete:{0}", assetPath);
        return AssetDeleteResult.DidNotDelete;
    }
}
