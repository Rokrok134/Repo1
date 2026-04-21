using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public Transform TargetObject;

    public Vector3 Offset = new Vector3(0f, 3f, -5f);

    public float mouseSensitivity = 200f;
    public float smoothSpeed = 5f;

    private float currentYRotation = 0f;

    private void LateUpdate()
    {
        if (TargetObject != null)
        {
            // Mausbewegung (nur X-Achse = links/rechts)
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            currentYRotation += mouseX;

            // Rotation um den Spieler
            Quaternion rotation = Quaternion.Euler(0f, currentYRotation, 0f);

            Vector3 desiredPosition = TargetObject.position + rotation * Offset;

            // Smooth movement
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

            // Immer auf Spieler schauen
            transform.LookAt(TargetObject);
        }
    }
}