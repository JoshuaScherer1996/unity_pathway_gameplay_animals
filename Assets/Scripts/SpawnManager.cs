using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private const float SpawnRangeX = 15.0f;
    private const float SpawnRangeZ = 19.9f;
    private const float DelayStart = 2.0f;
    private const float SpawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), DelayStart, SpawnInterval);
    }

    void SpawnRandomAnimal()
    {
        var spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnRangeZ);
        var animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(
            animalPrefabs[animalIndex], 
            spawnPos,
            animalPrefabs[animalIndex].transform.rotation
        );
    }
}

