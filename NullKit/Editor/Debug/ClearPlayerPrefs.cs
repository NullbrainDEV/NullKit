using UnityEditor;
using UnityEngine;

public static class NullKitPrefs
{
    [MenuItem("NullKit/Debug/Clear PlayerPrefs")]
    public static void ClearPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("[NullKit] PlayerPrefs cleared.");
    }
}
