using UnityEditor;
using UnityEngine;

public static class PrefabValidator
{
    [MenuItem("NullKit/VR Tools/Validate Selected Prefab")]
    public static void ValidateSelectedPrefab()
    {
        if (Selection.activeGameObject == null)
        {
            Debug.LogWarning("[NullKit] No GameObject selected.");
            return;
        }

        GameObject obj = Selection.activeGameObject;
        string result = "[NullKit Prefab Validator] " + obj.name + ":\n";

        if (!obj.GetComponent<Collider>())
            result += "- Missing Collider\n";
        if (!obj.GetComponent<Rigidbody>())
            result += "- Missing Rigidbody\n";
        if (obj.GetComponentsInChildren<Transform>().Length <= 1)
            result += "- No child components (might be empty)\n";

        Debug.Log(result);
    }
}
