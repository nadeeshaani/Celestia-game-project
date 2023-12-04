using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceshipCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Celestial"))
        {
            SceneManager.LoadScene("SolarSystem");
        }
    }
}

