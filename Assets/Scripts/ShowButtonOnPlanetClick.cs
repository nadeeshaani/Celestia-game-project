using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButtonOnPlanetClick: MonoBehaviour
{
    public GameObject button;  // Assign the Button GameObject in the Inspector

    private void Start()
    {
        button.SetActive(false);  // Hide the button initially
    }

    public void ShowButton()
    {
        button.SetActive(true);  // Show the button
    }

    public void HideButton()
    {
        button.SetActive(false);  // Hide the button
    }

}
