using UnityEngine;

public class DataManager : MonoBehaviour
{
    // Data variables to be stored between scenes
    public string previousSceneName;
    public Vector3 spaceshipPosition;
    public bool isOrbitingEnabled; // Added variable to store the toggle state

    // Static reference for easy access across scenes
    private static DataManager instance;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject); // Ensures only one instance exists
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject); // Persists this object between scenes
    }


    // Methods to update or retrieve stored data
    public void UpdatePreviousScene(string sceneName)
    {
        previousSceneName = sceneName;
    }

    public void UpdateSpaceshipPosition(Vector3 position)
    {
        spaceshipPosition = position;
    }

    public Vector3 GetSpaceshipPosition()
    {
        return spaceshipPosition;
    }

    public void UpdateOrbitingState(bool isEnabled)
    {
        isOrbitingEnabled = isEnabled;
    }

    public bool GetOrbitingState()
    {
        return isOrbitingEnabled;
    }


    public static DataManager GetInstance()
    {
        return instance;
    }
}

