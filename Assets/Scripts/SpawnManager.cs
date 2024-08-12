using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    // Declaring and Initializing variables and constants.
    public GameObject[] animalPrefabs;
    private const float SpawnRangeX = 15.0f;
    private const float SpawnRangeZ = 19.9f;
    private const float UpperBound = 14.0f;
    private const float LowerBound = 5.0f;
    private const float SideBound = 25.0f;
    private const float DelayStart = 2.0f;
    private const float SpawnInterval = 1.5f;
    private readonly Quaternion[] _animalRotation =
    {
        Quaternion.Euler(0, 90, 0),
        Quaternion.Euler(0, 180, 0),
        Quaternion.Euler(0, 270, 0),
    };

    // Repeats the named method constantly based on the start and interval times.
    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), DelayStart, SpawnInterval);
    }

    // Creates random animal objects at random locations.
    void SpawnRandomAnimal()
    {
        // Randomly determines the spawn direction.
        var spawnDirection = Random.Range(0, 3);

        // Declaring holder Variables.
        Vector3 spawnPos;
        Quaternion spawnRotation;

        // Setting spawn position and rotation based on the direction.
        if (spawnDirection == 0) // right
        {
            spawnPos = new Vector3(-SideBound, 0, Random.Range(LowerBound, UpperBound));
            spawnRotation = _animalRotation[0];
        }
        else if (spawnDirection == 1) // top
        {
            spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnRangeZ);
            spawnRotation = _animalRotation[1];
        }
        else // left
        {
            spawnPos = new Vector3(SideBound, 0, Random.Range(LowerBound, UpperBound));
            spawnRotation = _animalRotation[2];
        }

        // Randomly selects the animal prefab.
        var animalIndex = Random.Range(0, animalPrefabs.Length);

        // Instantiates the selected animal at the determined position and rotation.
        Instantiate(
            animalPrefabs[animalIndex],
            spawnPos,
            spawnRotation
        );
    }
}