using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip clickSound; // Assign the click sound in the Inspector
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component from the same GameObject
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayClickSound()
    {
        // Play the click sound
        audioSource.PlayOneShot(clickSound);
    }
}

