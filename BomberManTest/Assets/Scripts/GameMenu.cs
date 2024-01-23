using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public Canvas canvas;

    public void RestartGame()
    {
        ///Restart current level

        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMenu()
    {
        ///Load menu scene

        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
