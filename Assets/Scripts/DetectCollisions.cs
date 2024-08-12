using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Overrides the OnTriggerEnter method. The colliding objects are destroyed.
    private void OnTriggerEnter(Collider other)
    {
        
        // If the collided objects are Player and Animal Lives will decrease. Current Lives will be shown.
        if (gameObject.CompareTag("Player") && other.CompareTag("Animal"))
        {
            Debug.Log("Game Over! The animals attacked!");
            PlayerController.Lives -= 1;
            Debug.Log($"Lives: {PlayerController.Lives }!");
        }
        // If the collided objects are Projectile and Animal the colliding objects are destroyed. Score increases and will be shown.
        else if (gameObject.CompareTag("Projectile") && other.CompareTag("Animal"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            PlayerController.Score += 1;
            Debug.Log($"Score: {PlayerController.Score}");
        }
    }
}