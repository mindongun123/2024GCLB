using System.Collections;
using System.Collections.Generic;
using MidniteOilSoftware;
using UnityEngine;

namespace MJGame
{
    public static class SpawnerCommon
    {
        public static GameObject SpawnObject(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            GameObject go = ObjectPoolManager.SpawnGameObject(prefab, position, rotation);
            return go;
        }

        public static void DespawnObject(GameObject go)
        {
            ObjectPoolManager.DespawnGameObject(go);
        }
    }
}
