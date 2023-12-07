using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipStart : MonoBehaviour
{
    [SerializeField] private Vector3 positionOffset = new Vector3(0.5f, 0.5f, 0); // Offset values (adjust as needed)

    // Start is called before the first frame update
    void Start()
    {
        DataManager dataManager = DataManager.GetInstance();
        if (dataManager != null)
        {
            // Set the spaceship's position to the stored position with the offset
            Vector3 storedPosition = dataManager.GetSpaceshipPosition() + positionOffset;
            transform.position = storedPosition;
            dataManager.UpdateSpaceshipPosition(storedPosition); // Update DataManager with the new position
        }
    }
}

