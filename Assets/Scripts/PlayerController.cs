using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Instantiating and Declaring variables.
    public float horizontalInput;
    public float speed = 20.0f;

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > 10)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (Time.deltaTime * speed * horizontalInput));
    }
}
