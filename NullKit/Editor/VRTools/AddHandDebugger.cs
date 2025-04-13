using UnityEditor;
using UnityEngine;

public static class AddHandDebugger
{
    [MenuItem("NullKit/VR Tools/Add Hand Target Debugger")]
    public static void AddDebugger()
    {
        if (Selection.activeGameObject)
        {
            Selection.activeGameObject.AddComponent<HandTargetDebugger>();
            Debug.Log("[NullKit] Hand debugger added to: " + Selection.activeGameObject.name);
        }
        else
        {
            Debug.LogWarning("[NullKit] Select a GameObject first.");
        }
    }
}
