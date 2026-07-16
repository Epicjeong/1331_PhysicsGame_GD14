using UnityEngine;

public class Rings : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject); // Destroys the pickup item } }
        }
    }
}