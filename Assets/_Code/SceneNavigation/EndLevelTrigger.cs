using System.Collections;
using System.Collections.Generic;
using _Code.Services.Interfaces;
using UnityEngine;

public class EndLevelTrigger : LevelTrigger
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) EndLevel();
    }
}
