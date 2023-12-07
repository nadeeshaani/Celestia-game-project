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

        // Retrieve the DataManager instance
        DataManager dataManager = DataManager.GetInstance();

        // Set the toggle state based on the stored value
        if (dataManager != null)
        {
            toggle.isOn = dataManager.GetOrbitingState();
            UpdateOrbitScripts(!toggle.isOn);
        }
    }

    private void OnToggleValueChanged(bool value)
    {
        UpdateOrbitScripts(!value); // Enable or disable the OrbitScript based on the toggle value

        // Update the DataManager with the new toggle state
        DataManager dataManager = DataManager.GetInstance();
        if (dataManager != null)
        {
            dataManager.UpdateOrbitingState(value);
        }
    }

    private void UpdateOrbitScripts(bool enable)
    {
        foreach (OrbitScript orbitScript in orbitScripts)
        {
            orbitScript.enabled = enable;
        }
    }
}

