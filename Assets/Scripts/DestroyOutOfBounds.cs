using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Initializing variables.
    private const float TopBounds = 20.0f;
    private const float LowerBounds = -10.0f;
    private const float SideBounds = 25.0f;

    private void Update()
    {
        // Destroys objects outside the field bounds. Also decreases Lives and Shows them.
        if (transform.position.z > TopBounds) // Top
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < LowerBounds) // Bottom
        {
            PlayerController.CheckAlive();
            Destroy(gameObject);
        }
        else if (transform.position.x > SideBounds) // Right
        {
            PlayerController.CheckAlive();
            Destroy(gameObject);
        } else if (transform.position.x < -SideBounds) // Left
        {
            PlayerController.CheckAlive();
            Destroy(gameObject);
        }
    }
}