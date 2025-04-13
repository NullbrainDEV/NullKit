using UnityEngine;
using System.IO;

namespace NullKit
{
    public static class NullModMetadataLoader
    {
        public static string GetModMetadata(string modFolder)
        {
            string path = Path.Combine(modFolder, "mod.json");
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return null;
        }
    }
}
