using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OrbitScript : MonoBehaviour
{
    public Transform center;  // The center of the ellipse (sun)
    private float initialDistance; // Initial distance from sun
    public float orbitalSpeed = 10f;    // Adjust in the Inspector
    public float eccentricity = 0.5f;   // Adjust to make the orbit more elliptical

    public bool canOrbit = true;  // Toggle to enable or disable orbiting

    private float angle = 0f;

    void Start()
    {
        initialDistance = Vector3.Distance(transform.position, center.position);

        
    }

    void Update()
    {
        if (canOrbit)
        {
            angle += orbitalSpeed * Time.deltaTime;
            float x = center.position.x + initialDistance * Mathf.Cos(angle);
            float z = center.position.z + initialDistance * Mathf.Sin(angle) * eccentricity;
            transform.position = new Vector3(x, transform.position.y, z);
        }
    }
}

