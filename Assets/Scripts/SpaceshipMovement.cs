using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Speed of the spaceship movement
    public float rotationSpeed = 100.0f; // Speed of the spaceship rotation

    public AudioSource whooshAudio;

    void Start()
    {
        // Get the AudioSource component from the Spaceship
        
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = Vector3.zero;
        float rotation = 0.0f;

        // Linear movement using arrow keys
        if (horizontalInput != 0)
        {
            movement.x = horizontalInput;
        }
        else if (verticalInput != 0)
        {
            movement.z = verticalInput;
        }

        // Rotation using z, x, c, v keys
        if (Input.GetKey(KeyCode.Z))
        {
            rotation = -rotationSpeed * Time.fixedDeltaTime;
        }
        else if (Input.GetKey(KeyCode.X))
        {
            rotation = rotationSpeed * Time.fixedDeltaTime;
        }
        else if (Input.GetKey(KeyCode.C))
        {
            transform.Rotate(Vector3.right, -rotationSpeed * Time.fixedDeltaTime);
        }
        else if (Input.GetKey(KeyCode.V))
        {
            transform.Rotate(Vector3.right, rotationSpeed * Time.fixedDeltaTime);
        }

        // Apply movement and rotation to the spaceship
        transform.Translate(movement * moveSpeed * Time.fixedDeltaTime, Space.Self);
        transform.Rotate(Vector3.up, rotation);

        whooshAudio = GetComponent<AudioSource>();

        if (horizontalInput != 0 || verticalInput != 0)
        {
            if (!whooshAudio.isPlaying) // Ensure sound isn't already playing
            {
                whooshAudio.Play(); // Play the sound
            }
        }
        else
        {
            whooshAudio.Stop(); // Stop the sound when no movement input
        }
    }
}

