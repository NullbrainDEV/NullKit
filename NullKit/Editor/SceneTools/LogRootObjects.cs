using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class NullKitSceneTools
{
    [MenuItem("NullKit/Scene Tools/Log Root GameObjects")]
    public static void LogRootObjects()
    {
        foreach (var obj in SceneManager.GetActiveScene().GetRootGameObjects())
            Debug.Log("[NullKit] Root Object: " + obj.name);
    }
}
