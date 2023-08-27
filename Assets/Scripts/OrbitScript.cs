using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OrbitScript : MonoBehaviour
{
    public Transform center;  // The center of the ellipse (sun)
    private float initialDistance; // Initial distance from sun
    public float orbitalSpeed = 10f;    // Adjust in the Inspector

    private float angle = 0f;

    void Start()
    {
        initialDistance = Vector3.Distance(transform.position, center.position);
    }

    void Update()
    {
        angle += orbitalSpeed * Time.deltaTime;
        float x = center.position.x + initialDistance * Mathf.Cos(angle);
        float z = center.position.z + initialDistance * Mathf.Sin(angle);
        transform.position = new Vector3(x, transform.position.y, z);
    }
}
