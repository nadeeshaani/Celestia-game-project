using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleOrbits : MonoBehaviour
{
    public TrailRenderer[] planetOrbits; // Assign the trail renderers in the Inspector
    public Toggle toggle;

    private bool orbitsVisible = false;

    private void Awake()
    {
        toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(OnToggleValueChanged);

        foreach (TrailRenderer orbit in planetOrbits)
        {
            orbit.enabled = false;
        }
    }

    private void OnToggleValueChanged(bool value)
    {
        orbitsVisible = value; // Reverse the value

        foreach (TrailRenderer orbit in planetOrbits)
        {
            if (orbitsVisible)
            {
                // Enable the trail renderer and reset its time
                orbit.enabled = true;
                orbit.Clear();
            }
            else
            {
                // Disable the trail renderer
                orbit.enabled = false;
            }
        }
    }
}

