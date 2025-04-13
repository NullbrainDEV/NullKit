using UnityEditor;
using UnityEngine;
using System.Diagnostics;

public static class NullKitFolders
{
    [MenuItem("NullKit/Tools/Open Project Folder")]
    public static void OpenFolder()
    {
        Process.Start(System.IO.Path.GetFullPath("."));
        UnityEngine.Debug.Log("[NullKit] Project folder opened.");
    }
}
