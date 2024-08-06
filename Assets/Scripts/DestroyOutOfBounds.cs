using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Initializing variables.
    public float topBounds = 20.0f;
    public float lowerBounds = -10.0f;
    
    private void Update()
    {
        // Destroys object outside the upper and lower bounds.
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
