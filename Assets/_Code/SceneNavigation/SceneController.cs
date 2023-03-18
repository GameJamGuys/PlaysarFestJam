using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour, ISceneController
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) Restart();
        if (Input.GetKeyDown(KeyCode.N)) NextLevel();
        if (Input.GetKeyDown(KeyCode.Escape)) Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
