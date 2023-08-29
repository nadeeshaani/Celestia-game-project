using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSpeed = 5f;  // Adjust the zoom speed in the Inspector
    public float minZoomDistance = 1f;  // Adjust the minimum zoom distance in the Inspector
    public float maxZoomDistance = 20f;  // Adjust the maximum zoom distance in the Inspector

    void Update()
    {
        float zoomAmount = -Input.GetAxis("Mouse ScrollWheel");  // Get the scroll wheel input

        // Calculate the new position for the camera
        Vector3 newPosition = transform.position + transform.forward * zoomAmount * zoomSpeed;

        // Clamp the zoom distance within the min and max values
        newPosition.y = Mathf.Clamp(newPosition.y, minZoomDistance, maxZoomDistance);

        // Apply the new position to the camera
        transform.position = newPosition;
    }
}
