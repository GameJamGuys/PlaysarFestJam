using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public interface ISceneController
{
    public abstract void Restart();
    public abstract void NextLevel();
    public abstract void GoToMenu();
    public abstract void Quit();
}
