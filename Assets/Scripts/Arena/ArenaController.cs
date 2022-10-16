using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arena
{
    public class ArenaController : MonoBehaviour
    {
        [SerializeField] private MenuArena menu;
        public MenuArena Menu => menu;
        [SerializeField] private SpawnPointController spawnPointController;
        public SpawnPointController SpawnPoints => spawnPointController;
    }
}
