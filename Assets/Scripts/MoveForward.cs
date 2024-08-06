using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Initializing variables.
    public float speed = 20.0f;
    
    // Moves the object forward.
    private void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}
