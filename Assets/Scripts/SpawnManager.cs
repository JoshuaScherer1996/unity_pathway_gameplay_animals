using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    // Declaring and Initializing variables.
    public GameObject[] animalPrefabs;
    private const float SpawnRangeX = 15.0f;
    private const float SpawnRangeZ = 19.9f;
    private const float DelayStart = 2.0f;
    private const float SpawnInterval = 1.5f;

    // Repeats the named method constantly based on the start and interval times.
    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), DelayStart, SpawnInterval);
    }

    // Creates random animal objects at random locations.
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

