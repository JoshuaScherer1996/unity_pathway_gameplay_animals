using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Declaring and Initializing variables.
    public float horizontalInput;
    public float verticalInput;
    public float speed = 40.0f;
    public float xRange = 14.0f;
    public float zRange = 14.0f;
    public GameObject projectilePrefab;

    
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
}
