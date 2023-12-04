using UnityEngine;

public class SkyboxFollowSpaceship : MonoBehaviour
{
    public Transform spaceship;
    public float fovSpeed = 1.0f;

    private Camera mainCamera;
    private float initialFOV;

    void Start()
    {
        mainCamera = Camera.main;
        initialFOV = mainCamera.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the spaceship reference is set
        if (spaceship != null)
        {
            // Calculate the new FOV based on the spaceship's forward movement
            float newFOV = initialFOV + (spaceship.transform.position.z * fovSpeed);

            // Apply the new FOV within a certain range
            mainCamera.fieldOfView = Mathf.Clamp(newFOV, initialFOV - 20f, initialFOV + 20f);
        }
    }
}
