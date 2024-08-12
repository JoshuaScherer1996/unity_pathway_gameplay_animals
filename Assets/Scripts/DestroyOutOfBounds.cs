using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Initializing variables.
    private const float TopBounds = 20.0f;
    private const float LowerBounds = -10.0f;
    private const float SideBounds = 25.0f;

    private void Update()
    {
        // Destroys object outside the field bounds.
        if (transform.position.z > TopBounds) // Top
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < LowerBounds) // Bottom
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        else if (transform.position.x > SideBounds) // Right
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        } else if (transform.position.x < -SideBounds) // Left
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}