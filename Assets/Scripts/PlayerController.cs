using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Declaring and Initializing variables.
    public float horizontalInput;
    public float verticalInput;
    public static int Lives = 3;
    public static int Score = 0;
    public float speed = 40.0f;
    public float xRange = 14.0f;
    public float zRange = 14.0f;
    public GameObject projectilePrefab;
    // Flag to track if the player is dead
    public static bool IsPlayerDead = false;
    
    private void Update()
    {
        // Keeps the Player Inside the left bound of the game field.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        // Keeps the Player Inside the right bound of the game field.
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        // Creates the projectiles when space is pressed.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
        // Player input and movement.
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * (Time.deltaTime * speed * horizontalInput));
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * verticalInput));
    }

    // Method manages the Lives and Game Over System.
    public static void CheckAlive()
    {
        if (!IsPlayerDead)
        {
            Lives -= 1;
            Debug.Log($"Lives: {Lives}!");
            
            if (Lives <= 0)
            {
                Debug.Log("You Died! Game Over!");
                IsPlayerDead = true;
                Destroy(GameObject.FindWithTag("Player"));
            }
        }
        
    }
}
