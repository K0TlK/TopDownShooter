using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnPointController : MonoBehaviour
{
    [SerializeField] private List<Transform> spawnPoints = new List<Transform>();
    private List<Transform> emptySpawnPoint;

    public void Reload()
    {
        emptySpawnPoint = new List<Transform>(spawnPoints);
    }

    public Transform GetFreePoint()
    {
        int index = Random.Range(0, emptySpawnPoint.Count - 1);
        Transform transform = emptySpawnPoint[index];
        emptySpawnPoint.RemoveAt(index);
        return transform;
    }
}
