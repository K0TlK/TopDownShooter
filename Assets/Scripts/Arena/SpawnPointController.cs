using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Arena
{
    public class SpawnPointController : MonoBehaviour
    {
        [SerializeField] private List<Transform> spawnPoints = new List<Transform>();
        private List<Transform> emptySpawnPoint;
        public int freePoints => emptySpawnPoint.Count - 1;

        public void Reload()
        {
            emptySpawnPoint = new List<Transform>(spawnPoints);
            foreach (Transform t in spawnPoints)
            {
                for (var i = t.childCount - 1; i >= 0; i--)
                {
                    Object.Destroy(t.GetChild(i).gameObject);
                }
            }
        }

        public Transform GetFreePoint()
        {
            if (emptySpawnPoint.Count == 0)
            {
                Debug.LogError("No empty points!");
            }
            int index = Random.Range(0, emptySpawnPoint.Count);
            Transform transform = emptySpawnPoint[index];
            emptySpawnPoint.RemoveAt(index);
            return transform;
        }
    }
}
