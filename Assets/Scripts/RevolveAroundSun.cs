using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveAroundSun : MonoBehaviour
{
    public Transform sun;          // The sun's Transform
    public float orbitalSpeed = 10f;    // Adjust in the Inspector

    private Vector3 initialOffset;  // Initial offset from the sun

    void Start()
    {
        initialOffset = transform.position - sun.position;
    }

    void Update()
    {
        transform.position = sun.position + initialOffset;
        transform.RotateAround(sun.position, Vector3.up, orbitalSpeed * Time.deltaTime);
    }
}

