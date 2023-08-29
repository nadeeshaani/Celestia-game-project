using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToggleStopOrbiting : MonoBehaviour
{
    public OrbitScript[] orbitScripts;  // Assign the OrbitScript components for all planets in the Inspector
    private Toggle toggle;

    private void Awake()
    {
        toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }

    private void OnToggleValueChanged(bool value)
    {
        foreach (OrbitScript orbitScript in orbitScripts)
        {
            orbitScript.enabled = !value;  // Enable or disable the OrbitScript based on the toggle value
        }
    }
}
