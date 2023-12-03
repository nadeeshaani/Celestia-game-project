using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Reference to the spaceship GameObject
    public Vector3 offset;   // Offset distance between the spaceship and camera

    public float rotationSpeed = 5.0f; // Speed of camera rotation

    private float mouseX, mouseY;

    void LateUpdate()
    {
        // Mouse input for camera rotation
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -90f, 90f); // Limit vertical rotation

        // Apply rotation to camera and make it look at the spaceship
        Quaternion rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Vector3 newPosition = target.position - (rotation * offset);
        transform.position = newPosition;
        transform.LookAt(target.position);
    }
}
