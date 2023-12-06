using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceshipCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        string collidedObjectName = collision.gameObject.name;

        if (collidedObjectName.Equals("Mercury"))
        {
            SceneManager.LoadScene("Mercury");
        }
        else if (collidedObjectName.Equals("Venus"))
        {
            SceneManager.LoadScene("Venus");
        }
        else if (collidedObjectName.Equals("Earth"))
        {
            SceneManager.LoadScene("Earth");
        }
        else if (collidedObjectName.Equals("Mars"))
        {
            SceneManager.LoadScene("Mars");
        }
        else if (collidedObjectName.Equals("Jupiter"))
        {
            SceneManager.LoadScene("Jupiter");
        }
        else if (collidedObjectName.Equals("Saturn"))
        {
            SceneManager.LoadScene("Saturn");
        }
        else if (collidedObjectName.Equals("Uranus"))
        {
            SceneManager.LoadScene("Uranus");
        }
        else if (collidedObjectName.Equals("Neptune"))
        {
            SceneManager.LoadScene("Neptune");
        }
    }
}


