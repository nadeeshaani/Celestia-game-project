using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetLabel : MonoBehaviour
{
    private Transform planetTransform;  // The planet's Transform component
    private TextMesh nameLabel;         // The attached TextMesh component

    private void Start()
    {
        planetTransform = transform;  // Assign the planet's Transform
        nameLabel = GetComponentInChildren<TextMesh>();  // Find the child TextMesh component
    }

    private void Update()
    {
        // Update the position of the label to match the planet's position
        nameLabel.transform.position = planetTransform.position;

        // Make the label always face the camera
        nameLabel.transform.LookAt(Camera.main.transform);
    }
}
