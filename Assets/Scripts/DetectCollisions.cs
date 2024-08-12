using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Overrides the OnTriggerEnter method. The colliding objects are destroyed.
    private void OnTriggerEnter(Collider other)
    {
        // If the collided objects are Player and Animal a Game Over Log will be shown.
        if (gameObject.CompareTag("Player") && other.CompareTag("Animal") ||
            gameObject.CompareTag("Animal") && other.CompareTag("Player"))
        {
            Debug.Log("Game Over! The animals attacked!");
        }
        // If the collided objects are Projectile and Animal the colliding objects are destroyed.
        else if (gameObject.CompareTag("Projectile") && other.CompareTag("Animal") ||
                 gameObject.CompareTag("Animal") && other.CompareTag("Projectile"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}