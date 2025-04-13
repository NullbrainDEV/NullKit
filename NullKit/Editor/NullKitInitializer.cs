using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public static class NullKitInitializer
{
    static NullKitInitializer()
    {
        if (!EditorPrefs.HasKey("NullKit_Initialized"))
        {
            Debug.Log("[NullKit] Welcome to NullKit for Bonelab modding!");
            EditorPrefs.SetBool("NullKit_Initialized", true);
            EditorApplication.delayCall += () =>
            {
                NullKitWindow.ShowWindow();
            };
        }
    }
}
