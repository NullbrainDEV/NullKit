using UnityEditor;
using UnityEngine; // <- Needed for Debug.Log

public static class NullKitCompile
{
    [MenuItem("NullKit/Editor/Force Recompile")]
    public static void Recompile()
    {
        UnityEditor.Compilation.CompilationPipeline.RequestScriptCompilation();
        Debug.Log("[NullKit] Script recompilation requested.");
    }
}
