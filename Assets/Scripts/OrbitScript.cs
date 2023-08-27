using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OrbitScript : MonoBehaviour
{
    public Transform center;  // The center of the ellipse
    public float semiMajorAxis = 1.0f;  // Adjust in the Inspector
    public float semiMinorAxis = 0.5f;  // Adjust in the Inspector
    public float orbitalSpeed = 10f;    // Adjust in the Inspector

    private float angle = 0f;

    void Update()
    {
        angle += orbitalSpeed * Time.deltaTime;
        float x = center.position.x + semiMajorAxis * Mathf.Cos(angle);
        float z = center.position.z + semiMinorAxis * Mathf.Sin(angle);
        transform.position = new Vector3(x, transform.position.y, z);
    }
}

