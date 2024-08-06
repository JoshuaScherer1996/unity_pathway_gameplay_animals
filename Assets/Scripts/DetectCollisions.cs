using System;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Overrides the OnTriggerEnter method. The colliding objects are destoyed.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
