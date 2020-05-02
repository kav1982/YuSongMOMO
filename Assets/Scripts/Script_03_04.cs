//using UnityEditor;
//using UnityEngine;
//using System.Collections.Generic;

////AssetModificationProcessor 资产修改处理器，空类。
//public class Script_03_04 : UnityEditor.AssetModificationProcessor
//{
//    //允许在Unity加载时初始化编辑器类方法而无需用户采取任何措施
//    //Allow an editor class method to be initialized when Unity loads without action from the user.
//    //只对方法有效，每个方法调用时都会调用
//    [InitializeOnLoadMethod]
//    static void InitializeOnLoadMethod() //通过反射全局监听资源是否发生变化（添加删除移动...）
//    {
//        EditorApplication.projectChanged += delegate ()
//        {
//            Debug.Log("change");
//        };
//    }

//    public static bool IsOpenForEdit(string assetPath, out string message) //监听双击鼠标打开资源
//    {
//        message = null;
//        Debug.LogFormat("assetPath:{0}", assetPath);
//        return true;
//    }

//    public static void OnWillCreateAsset(string path)  //监听资源即将被创建
//    {
//        Debug.LogFormat("path:{0}", path);
//    }

//    public static string[] OnWillSaveAssets(string[] paths) //资源将被保存
//    {
//        if (paths != null)
//        {
//            Debug.LogFormat("path:{0}", string.Join(",", paths));
//        }
//        return paths;
//    }

//    public static AssetMoveResult OnWillMoveAsset(string oldPath, string newPath) //资源将被移动
//    {
//        Debug.LogFormat("from:{0} to:{1}", oldPath, newPath);
//        return AssetMoveResult.DidMove;
//    }

//    public static AssetDeleteResult OnWillDeleteAsset(string assetPath, RemoveAssetOptions option) //资源将被删除
//    {
//        Debug.LogFormat("delete:{0}", assetPath);
//        return AssetDeleteResult.DidNotDelete;
//    }
//}
