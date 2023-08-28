using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSkyBox : MonoBehaviour
{
    public Material planetSkybox;  // Assign the respective planet's skybox material
    public GameObject objectsToHide; // Assign the parent GameObject for objects you want to hide
    public ShowButtonOnPlanetClick buttonScript;  // Assign the ShowButtonOnPlanetClick script component


    private void OnMouseDown()
    {
        // Hide the current objects
        objectsToHide.SetActive(false);

        // Show the button
        buttonScript.ShowButton();

        // Set the new skybox
        RenderSettings.skybox = planetSkybox;
        DynamicGI.UpdateEnvironment();

        // Perform other actions if needed
    }
}
