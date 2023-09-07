using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentAudio : MonoBehaviour
{
    private void Awake()
    {
        // Check if there's another instance of this GameObject in the scene
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Persistent");
        if (objs.Length > 1)
        {
            // Destroy this instance if another one already exists
            Destroy(gameObject);
        }
        else
        {
            // Make this GameObject persistent through scene changes
            DontDestroyOnLoad(gameObject);
        }
    }
}
