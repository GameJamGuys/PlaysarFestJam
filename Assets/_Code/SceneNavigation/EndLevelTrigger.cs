using System.Collections;
using System.Collections.Generic;
using _Code.Services.Interfaces;
using UnityEngine;

public class EndLevelTrigger : MonoBehaviour, ILevelTrigger
{
    [SerializeField]
    private int level;

    public void Init()
    {

    }

    public void Init(ITriggerService triggerService)
    {
        throw new System.NotImplementedException();
    }

    public void EndLevel()
    {
        throw new System.NotImplementedException();
    }

    public void FailLevel()
    {
        throw new System.NotImplementedException();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //SceneController.NextLevel();
        }
    }

}
