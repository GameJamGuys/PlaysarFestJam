using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneService : MonoBehaviour, ISceneService
{
    int sceneCount;
    int sceneIndex;

    public void Init()
    {
        
    }

    private void Start()
    {
        sceneCount = SceneManager.sceneCountInBuildSettings;
        sceneIndex = SceneManager.GetActiveScene().buildIndex;

        print($"Scene {sceneIndex}");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) Restart();
        if (Input.GetKeyDown(KeyCode.N)) NextLevel();
        if (Input.GetKeyDown(KeyCode.Escape)) Quit();
    }

    public void Restart() => Load(SceneManager.GetActiveScene().buildIndex);

    public void NextLevel()
    {
        
        if (sceneIndex == sceneCount - 1)
            GoToMenu();
        else
            Load(sceneIndex + 1);
    }

    public void GoToMenu() => Load(0);

    public void Quit() => Application.Quit();

    void Load(int scene) => SceneManager.LoadScene(scene);

}
