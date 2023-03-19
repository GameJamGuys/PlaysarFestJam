using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _Code.Data;
using HelpTools;

public class DangerArea : LevelTrigger
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag(TagType.Robot.ToString()))
        {
            WaitAndDestroy(collision.gameObject);
        }

        if (collision.CompareTag(TagType.Player.ToString()))
        {
            DestroyAndRestart(collision.gameObject);
        }
    }

    async void WaitAndDestroy(GameObject destroyObject)
    {
        await Timer.Wait(0.15f);
        Destroy(destroyObject);
    }

    async void DestroyAndRestart(GameObject destroyObject)
    {
        await Timer.Wait(0.15f);
        Destroy(destroyObject);
        await Timer.Wait(0.3f);
        RestartLevel();
    }
}
