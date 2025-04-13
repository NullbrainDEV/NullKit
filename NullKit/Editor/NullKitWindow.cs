using UnityEditor;
using UnityEngine;
using NullKit;

public class NullKitWindow : EditorWindow
{
    private Vector2 scroll;

    [MenuItem("NullKit/Dashboard")]
    public static void ShowWindow()
    {
        var window = GetWindow<NullKitWindow>("NullKit Dashboard");
        window.minSize = new Vector2(420, 400);
    }

    private void OnGUI()
    {
        GUILayout.Label("NullKit SDK", EditorStyles.boldLabel);
        EditorGUILayout.HelpBox("A modular SDK for Bonelab modding. Use the tools below to manage and debug your mods.", MessageType.Info);
        GUILayout.Space(10);

        scroll = EditorGUILayout.BeginScrollView(scroll);

        DrawSection("Mod Registry", () =>
        {
            if (GUILayout.Button("Log Registered Mods"))
            {
                var mods = NullModRegistry.GetRegisteredMods();
                if (mods.Count == 0)
                    Debug.Log("[NullKit] No mods registered.");
                else
                    foreach (var mod in mods)
                        Debug.Log($"[NullKit] Registered Mod: {mod}");
            }
        });

        DrawSection("Metadata Loader", () =>
        {
            if (GUILayout.Button("Load Example mod.json"))
            {
                string json = NullModMetadataLoader.GetModMetadata("Mods/ExampleMod");
                Debug.Log(string.IsNullOrEmpty(json) ? "[NullKit] No mod.json found." : $"[NullKit] Loaded JSON:\n{json}");
            }
        });

        DrawSection("Logger", () =>
        {
            if (GUILayout.Button("Log Info"))
                NullLogger.Log("This is a sample log from NullKitWindow.", "NullKitDemo");

            if (GUILayout.Button("Log Warning"))
                NullLogger.Warn("This is a sample warning.", "NullKitDemo");

            if (GUILayout.Button("Log Error"))
                NullLogger.Error("This is a sample error.", "NullKitDemo");
        });

        EditorGUI.BeginDisabledGroup(!Application.isPlaying);
        DrawSection("Dev Panel (Play Mode Only)", () =>
        {
            if (GUILayout.Button("Toggle Dev Panel"))
                NullDevPanel.TogglePanel();
        });
        EditorGUI.EndDisabledGroup();

        DrawSection("Script Injector", () =>
        {
            if (GUILayout.Button("Inject DummyScript to 'TestTag' objects"))
                NullScriptInjector.Inject<DummyScript>("TestTag");
        });

        DrawSection("Event Bus", () =>
        {
            if (GUILayout.Button("Emit TestEvent"))
                NullEventBus.Emit("TestEvent");

            if (GUILayout.Button("Subscribe to TestEvent"))
                NullEventBus.Subscribe("TestEvent", () => Debug.Log("[NullKit] TestEvent received."));
        });

        DrawSection("Prefab Spawner", () =>
        {
            EditorGUILayout.HelpBox("Prefab spawning must be triggered from runtime code.", MessageType.Info);
        });

        EditorGUILayout.EndScrollView();
    }

    private void DrawSection(string title, System.Action content)
    {
        GUILayout.Space(10);
        EditorGUILayout.LabelField(title, EditorStyles.boldLabel);
        EditorGUILayout.BeginVertical("box");
        content.Invoke();
        EditorGUILayout.EndVertical();
    }
}
