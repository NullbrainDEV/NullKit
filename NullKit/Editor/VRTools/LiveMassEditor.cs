using UnityEditor;
using UnityEngine;

public class LiveMassEditor : EditorWindow
{
    private Rigidbody targetRb;
    private float massValue = 1f;

    [MenuItem("NullKit/VR Tools/Live Mass Editor")]
    public static void ShowWindow()
    {
        GetWindow<LiveMassEditor>("Live Mass Editor");
    }

    void OnGUI()
    {
        GUILayout.Label("Edit Rigidbody Mass in Real Time", EditorStyles.boldLabel);

        targetRb = EditorGUILayout.ObjectField("Target Rigidbody", targetRb, typeof(Rigidbody), true) as Rigidbody;

        if (targetRb)
        {
            EditorGUI.BeginChangeCheck();
            float newMass = EditorGUILayout.Slider("Mass", targetRb.mass, 0.1f, 100f);
            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(targetRb, "Change Rigidbody Mass");
                targetRb.mass = newMass;
                EditorUtility.SetDirty(targetRb);
                Debug.Log($"[NullKit] Updated Rigidbody mass: {newMass}");
            }
        }
        else
        {
            EditorGUILayout.HelpBox("Assign a Rigidbody from the scene.", MessageType.Info);
        }
    }
}
