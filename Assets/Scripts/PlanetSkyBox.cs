using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSkyBox : MonoBehaviour
{
    public Material planetSkybox;  // Assign the respective planet's skybox material
    public GameObject objectsToHide; // Assign the parent GameObject for objects you want to hide
    public ShowButtonOnPlanetClick buttonScript;  // Assign the ShowButtonOnPlanetClick script component
    public ShowScrollViewOnPlanetClick scrollViewScript;
    public AudioClip clickSound; // Assign the click sound in the inspector

    private AudioSource audioSource; // Reference to the AudioSource component

    private void Start()
    {
        // Fetch AudioSource component or add it if not present
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the click sound to the AudioSource
        audioSource.clip = clickSound;
    }

    private void OnMouseDown()
    {
        // Hide the current objects
        objectsToHide.SetActive(false);

        // Show the button
        buttonScript.ShowButton();

        // Play the click sound
        if (clickSound != null)
        {
            audioSource.Play();
        }

        // Set the new skybox
        RenderSettings.skybox = planetSkybox;
        DynamicGI.UpdateEnvironment();

        // Perform other actions if needed
    }
}

