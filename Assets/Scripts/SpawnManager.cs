using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private const float SpawnRangeX = 20.0f;
    private const float SpawnRangeZ = 19.9f;


    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SpawnRandomAnimal();
        }
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

