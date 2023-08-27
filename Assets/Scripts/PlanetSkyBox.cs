using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSkyBox : MonoBehaviour
{
    public Material planetSkybox;  // Assign the respective planet's skybox material
    public GameObject objectsToHide; // Assign the parent GameObject for objects you want to hide

    private void OnMouseDown()
    {
        // Hide the current objects
        objectsToHide.SetActive(false);

        // Set the new skybox
        RenderSettings.skybox = planetSkybox;
        DynamicGI.UpdateEnvironment();

        // Perform other actions if needed
    }
}
