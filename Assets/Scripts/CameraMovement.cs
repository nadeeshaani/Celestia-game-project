using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float mouseSensitivity = 2.0f;  // Mouse sensitivity
    public float keyboardMoveSpeed = 5.0f;  // Keyboard movement speed

    private Vector3 rotation;

    void Update()
    {
        // Mouse rotation
        rotation.y += Input.GetAxis("Mouse X") * mouseSensitivity;
        rotation.x -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotation.x = Mathf.Clamp(rotation.x, -90f, 90f); // Limit vertical rotation
        transform.eulerAngles = rotation;

        // Keyboard movement
        float horizontalInput = Input.GetAxis("Horizontal");  // Get horizontal arrow key input
        float verticalInput = Input.GetAxis("Vertical");  // Get vertical arrow key input

        // Calculate the movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);

        // Normalize the movement direction and apply the speed
        Vector3 moveAmount = moveDirection.normalized * keyboardMoveSpeed * Time.deltaTime;

        // Convert the local movement to global movement
        Vector3 moveAmountGlobal = transform.TransformDirection(moveAmount);

        // Apply the movement to the camera's position
        transform.position += moveAmountGlobal;
    }
}
