using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene("SolarSystem");
    }
}
