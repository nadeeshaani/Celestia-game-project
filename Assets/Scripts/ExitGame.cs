using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Exit()
    {
        // Exit the application when the button is clicked
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}

