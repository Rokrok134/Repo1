using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 100f;

    // 👇 NEU: frei einstellbare Rotationsachse
    public Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        // Rotate the coin
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
