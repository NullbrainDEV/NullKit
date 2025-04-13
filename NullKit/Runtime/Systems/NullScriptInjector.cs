using UnityEngine;

namespace NullKit
{
    public static class NullScriptInjector
    {
        public static void Inject<T>(string tag) where T : Component
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);
            foreach (var obj in objects)
            {
                if (obj.GetComponent<T>() == null)
                    obj.AddComponent<T>();
            }
        }
    }
}
