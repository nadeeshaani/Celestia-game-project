using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataManager dataManager = DataManager.GetInstance();
        if (dataManager != null)
        {
            // Set the spaceship's position to the stored position
            transform.position = dataManager.GetSpaceshipPosition();
        }
    }

   
}
