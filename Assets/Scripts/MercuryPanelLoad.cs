using UnityEngine;
using TMPro;


public class MercuryPanelLoad : MonoBehaviour
{

    public TextMeshProUGUI landingText;
    public TextMeshProUGUI landingInstruction;
    public GameObject mercuryPanel;

    public AudioSource notificationSound;


    void Start()
    {
        // Deactivate all panels when the scene starts
        DeactivateAllPanels();
        landingText.gameObject.SetActive(false);
        landingInstruction.gameObject.SetActive(true);
        notificationSound.gameObject.SetActive(false);
    }

    void DeactivateAllPanels()
    {
        mercuryPanel.SetActive(false);
        // marsPanel.SetActive(false);
        // Deactivate other panels for additional planets...
    }

    void OnTriggerEnter(Collider other)
    {
        string collidedObjectName = other.gameObject.name;

        if (collidedObjectName.Equals("Mercury"))
        {
            ActivatePanel(mercuryPanel);
            ActivateLandingMessage();
            DeactivateLandingInstruction();
            PlayNotificationSound();
        }

        // else if (collidedObjectName.Equals("Mars"))
        // {
        //    ActivatePanel(marsPanel);
        // }
        // Add more conditions for other planets...
    }

    void ActivatePanel(GameObject panel)
    {
        DeactivateAllPanels(); // Deactivate all panels first
        panel.SetActive(true); // Activate the selected panel
    }

    void ActivateLandingMessage()
    {
        landingText.gameObject.SetActive(true); // Activate the landing message
        Invoke("DeactivateLandingMessage", 5.0f); // Automatically deactivate after 5 seconds
    }

    void DeactivateLandingMessage()
    {
        landingText.gameObject.SetActive(false); // Deactivate the landing message
    }

    void DeactivateLandingInstruction()
    {
        landingInstruction.gameObject.SetActive(false);
    }

    void PlayNotificationSound()
    {
        if (notificationSound != null)
        {
            notificationSound.gameObject.SetActive(true);
            notificationSound.Play(); // Play the notification sound
        }
    }
}