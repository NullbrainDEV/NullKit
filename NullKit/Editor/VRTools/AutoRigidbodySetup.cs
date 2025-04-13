using UnityEditor;
using UnityEngine;

public static class AutoRigidbodySetup
{
    [MenuItem("NullKit/VR Tools/Auto-Setup Rigidbody & Collider")]
    public static void AutoSetup()
    {
        if (Selection.activeGameObject == null)
        {
            Debug.LogWarning("[NullKit] No GameObject selected.");
            return;
        }

        GameObject obj = Selection.activeGameObject;

        if (!obj.GetComponent<Collider>())
        {
            obj.AddComponent<BoxCollider>();
            Debug.Log("[NullKit] Added BoxCollider.");
        }

        if (!obj.GetComponent<Rigidbody>())
        {
            obj.AddComponent<Rigidbody>();
            Debug.Log("[NullKit] Added Rigidbody.");
        }

        Debug.Log("[NullKit] Auto setup complete for: " + obj.name);
    }
}
