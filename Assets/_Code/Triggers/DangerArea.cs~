using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _Code.Data;

public class DangerArea : LevelTrigger
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(TagType.Player.ToString()))
        {
            Destroy(collision.gameObject);
            RestartLevel();
        }

        if (collision.CompareTag(TagType.Robot.ToString()))
        {
            Destroy(collision.gameObject);
        }
    }
}
