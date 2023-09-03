using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public string SolarSystem;

    private void Start()
    {
        SceneManager.LoadSceneAsync(SolarSystem);
    }
}
