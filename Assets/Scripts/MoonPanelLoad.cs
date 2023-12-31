using UnityEngine;

public class MoonPanelLoad : MonoBehaviour
{
    public GameObject moonPanelLoad; // Assign the UI panel for Earth in the Inspector
    //public GameObject marsPanel; // Assign the UI panel for Mars in the Inspector
    // Add more panels for other planets as needed...

    void Start()
    {
        // Deactivate all panels when the scene starts
        DeactivateAllPanels();
    }

    void DeactivateAllPanels()
    {
        moonPanelLoad.SetActive(false);
        // marsPanel.SetActive(false);
        // Deactivate other panels for additional planets...
    }

    void OnCollisionEnter(Collision collision)
    {
        string collidedObjectName = collision.gameObject.name;

        if (collidedObjectName.Equals("Moon"))
        {
            ActivatePanel(moonPanelLoad);
        }

        //else if (collidedObjectName.Equals("Moon"))
        //{
        //    ActivatePanel(marsPanel);
        //}
        // Add more conditions for other planets...
    }

    void ActivatePanel(GameObject panel)
    {
        DeactivateAllPanels(); // Deactivate all panels first
        panel.SetActive(true); // Activate the selected panel
    }
}
