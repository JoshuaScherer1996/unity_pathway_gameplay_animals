using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    
    
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            var animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(
                animalPrefabs[animalIndex], 
                new Vector3(0, 0, 19.9f),
                animalPrefabs[animalIndex].transform.rotation
                );
        }
    }
}
