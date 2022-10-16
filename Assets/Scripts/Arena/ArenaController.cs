using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Arena
{
    public class ArenaController : MonoBehaviour
    {
        [SerializeField] private MenuArena menu;
        public MenuArena Menu => menu;
        [SerializeField] private SpawnPointController spawnPointController;
        [SerializeField] private GameObject[] ricochetObjects;
        public SpawnPointController SpawnPoints => spawnPointController;

        public void SpawnObjects()
        {
            int count = spawnPointController.freePoints;
            for (int i = 0; i < count; i++)
            {
                int index = Random.Range(0, ricochetObjects.Length);
                Instantiate(ricochetObjects[index], spawnPointController.GetFreePoint());
            }
        }
    }
}
