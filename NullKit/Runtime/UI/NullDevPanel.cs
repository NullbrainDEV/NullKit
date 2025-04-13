using UnityEngine;

namespace NullKit
{
    public class NullDevPanel : MonoBehaviour
    {
        private static NullDevPanel instance;
        private bool showPanel = false;

        public static void TogglePanel()
        {
#if UNITY_EDITOR
            if (!Application.isPlaying)
            {
                Debug.LogWarning("[NullKit] Dev Panel can only be used in Play Mode.");
                return;
            }
#endif
            if (instance == null)
            {
                GameObject panelObj = new GameObject("NullDevPanel");
                instance = panelObj.AddComponent<NullDevPanel>();
                DontDestroyOnLoad(panelObj);
            }

            instance.showPanel = !instance.showPanel;
        }

        private void OnGUI()
        {
            if (!showPanel) return;

            GUI.Box(new Rect(10, 10, 300, 200), "NullKit Dev Panel");
            if (GUI.Button(new Rect(20, 40, 260, 30), "Log Registered Mods"))
            {
                foreach (var mod in NullModRegistry.GetRegisteredMods())
                    NullLogger.Log(mod);
            }
        }
    }
}
