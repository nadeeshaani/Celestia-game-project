using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensitivity = 2.0f;  // Mouse sensitivity
    private Vector3 rotation;

    void Update()
    {
        // Rotate the camera based on mouse input
        rotation.y += Input.GetAxis("Mouse X") * sensitivity;
        rotation.x -= Input.GetAxis("Mouse Y") * sensitivity;
        rotation.x = Mathf.Clamp(rotation.x, -90f, 90f); // Limit vertical rotation
        transform.eulerAngles = rotation;
    }
}
