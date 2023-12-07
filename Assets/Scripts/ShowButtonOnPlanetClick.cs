using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButtonOnPlanetClick : MonoBehaviour
{
    public GameObject button;  // Assign the Button GameObject in the Inspector
    public AudioSource audioSource; // Reference to the AudioSource component

    private void Start()
    {
        button.SetActive(false);  // Hide the button initially

        // Fetch AudioSource component or add it if not present
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void ShowButton()
    {
        button.SetActive(true);  // Show the button
        audioSource.gameObject.SetActive(true);

        // Play the click sound when the button is shown
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }
    }

    public void HideButton()
    {
        button.SetActive(false);  // Hide the button
    }
}

