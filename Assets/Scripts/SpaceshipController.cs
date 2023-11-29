using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Speed of the spaceship movement
    public float rotationSpeed = 100.0f; // Speed of the spaceship rotation

    void Update()
    {
        // Get input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement based on input
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * moveSpeed * Time.deltaTime;

        // Apply the movement to the spaceship's position
        transform.Translate(movement);

        // Calculate rotation based on input
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        // Apply the rotation to the spaceship around its vertical axis (Yaw)
        transform.Rotate(Vector3.up, rotation);

        // Calculate tilt (pitch) based on input for tilting upwards or downwards
        float tilt = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;

        // Apply the tilt to the spaceship around its local X-axis (Pitch)
        transform.Rotate(Vector3.right, tilt);
    }
}


/*
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Speed of the spaceship movement
    public float rotationSpeed = 100.0f; // Speed of the spaceship rotation

    void Update()
    {
        // Get input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement based on input
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * moveSpeed * Time.deltaTime;

        // Apply the movement to the spaceship's position
        transform.Translate(movement);

        // Calculate rotation based on input
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        // Apply the rotation to the spaceship
        transform.Rotate(Vector3.up, rotation);
    }
}

*/

