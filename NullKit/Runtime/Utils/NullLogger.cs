using UnityEngine;

namespace NullKit
{
    public static class NullLogger
    {
        public static void Log(string message, string tag = "NULLKIT")
        {
            Debug.Log($"[{tag}] {message}");
        }

        public static void Warn(string message, string tag = "NULLKIT")
        {
            Debug.LogWarning($"[{tag}] {message}");
        }

        public static void Error(string message, string tag = "NULLKIT")
        {
            Debug.LogError($"[{tag}] {message}");
        }
    }
}
