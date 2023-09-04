using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public string mainSceneName;  // Name of your main game scene

    private void Start()
    {
        // Load the main game scene asynchronously
        SceneManager.LoadSceneAsync(mainSceneName);
    }
}

