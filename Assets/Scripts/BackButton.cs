using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public Material defaultSkybox;  // Assign the default skybox material in the Inspector
    public GameObject objectsToReactivate; // Assign the GameObject containing the hidden objects
    public ShowButtonOnPlanetClick showButtonScript;  // Assign the ShowButtonOnPlanetClick script in the Inspector


    public void OnBackButtonClick()
    {
        RenderSettings.skybox = defaultSkybox;  // Restore the default skybox
        DynamicGI.UpdateEnvironment();

        // Reactivate the hidden objects
        objectsToReactivate.SetActive(true);

        showButtonScript.HideButton();  // Hide the button
 

    }
}
