using System.Collections.Generic;
using UnityEngine;

namespace NullKit
{
    public static class NullModRegistry
    {
        private static List<string> registeredMods = new List<string>();

        public static void RegisterMod(string modName)
        {
            if (!registeredMods.Contains(modName))
            {
                registeredMods.Add(modName);
                NullLogger.Log($"Registered mod: {modName}", "ModRegistry");
            }
        }

        public static IReadOnlyList<string> GetRegisteredMods() => registeredMods;
    }
}
