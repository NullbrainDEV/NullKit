using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class VelocityTracer : MonoBehaviour
{
    private Rigidbody rb;

    void OnDrawGizmos()
    {
        if (!rb)
            rb = GetComponent<Rigidbody>();

        if (rb)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(transform.position, transform.position + rb.velocity);
        }
    }

    [MenuItem("NullKit/VR Tools/Add Velocity Tracer")]
    static void AddTracer()
    {
        if (Selection.activeGameObject)
        {
            var tracer = Selection.activeGameObject.AddComponent<VelocityTracer>();
            Debug.Log("[NullKit] Velocity tracer added to: " + tracer.name);
        }
        else
        {
            Debug.LogWarning("[NullKit] Select a GameObject first.");
        }
    }
}
