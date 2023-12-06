using UnityEngine;
using UnityEngine.SceneManagement;

public class SolarSystemPersistenceManager : MonoBehaviour
{
    static bool created = false;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
