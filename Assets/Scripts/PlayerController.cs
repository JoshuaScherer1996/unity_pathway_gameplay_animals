using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Instantiating and Declaring variables.
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 14.0f;

    public GameObject projectilePrefab;

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed");
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (Time.deltaTime * speed * horizontalInput));
    }
}
