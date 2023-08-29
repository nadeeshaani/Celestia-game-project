using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleOrbits : MonoBehaviour
{
    public TrailRenderer[] planetOrbits; // Assign the trail renderers in the Inspector
    public Toggle toggle;

    private void Awake()
    {
        toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }

    public void OnToggleValueChanged(bool value)
    {
        foreach (TrailRenderer orbit in planetOrbits)
        {
            orbit.enabled = !value; // Enable or disable the trail renderer based on the toggle value
        }
    }
}
