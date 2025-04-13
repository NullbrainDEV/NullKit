using UnityEngine;

namespace NullKit
{
    public static class NullPrefabSpawner
    {
        public static GameObject SpawnPrefab(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            if (prefab == null)
            {
                NullLogger.Warn("Tried to spawn a null prefab.", "Spawner");
                return null;
            }

            return GameObject.Instantiate(prefab, position, rotation);
        }
    }
}
