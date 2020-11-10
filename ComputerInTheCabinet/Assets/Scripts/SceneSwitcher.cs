using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GoToMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToFirstScene()
    {
        SceneManager.LoadScene("SceneOne");
    }

    public void GoToSecondScene()
    {
        SceneManager.LoadScene("SceneTwo");
    }
}