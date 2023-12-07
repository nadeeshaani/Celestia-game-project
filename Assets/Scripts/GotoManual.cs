using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoManual : MonoBehaviour
{
    public AudioClip clickSound; // Drag and assign the click sound in the Inspector

    private AudioSource audioSource;

    private void Start()
    {
        // Fetch AudioSource component or add it if not present
        audioSource = GetComponent<AudioSource>();
        
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Set the click sound to the AudioSource
        if (clickSound != null)
        {
            audioSource.clip = clickSound;
        }
    }

    public void LoadManual()
    {
        // Play the click sound
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.gameObject.SetActive(true);
            audioSource.Play();
        }

        // Load the appropriate scene after a delay (if needed)
        SceneManager.LoadScene("HowToPlay"); // Replace with your main menu scene name
    }
}

