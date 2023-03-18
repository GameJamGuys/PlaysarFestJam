using _Code.Data;
using UnityEngine;

public class EndLevelTrigger : LevelTrigger
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(TagType.Player.ToString()))
        {
            EndLevel();
        }
    }
}
