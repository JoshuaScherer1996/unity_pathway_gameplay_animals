using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 20.0f;
    public float lowerBounds = -10.0f;

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
    }
}
