using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    private static LoadingManager instance; // Singleton pattern
    private AsyncOperation asyncOperation;   // Asynchronous operation for scene loading

    private float loadingProgress = 0f;     // Loading progress percentage
    private bool isLoadingComplete = false; // Flag indicating if loading is complete

    private void Awake()
    {
        // Ensure there is only one instance of the LoadingManager
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    // Add loading methods here
}
