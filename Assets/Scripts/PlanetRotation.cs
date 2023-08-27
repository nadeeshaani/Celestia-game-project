using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlanetRotation : MonoBehaviour
{
    public float rotationSpeed = 10f;  // Adjust as needed

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}

