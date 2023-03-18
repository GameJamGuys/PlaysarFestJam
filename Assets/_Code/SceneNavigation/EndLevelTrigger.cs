using System.Collections;
using _Code.Data;
using _Code.Interactables;
using UnityEngine;

public class EndLevelTrigger : LevelTrigger
{
    [SerializeField] private ToggleBase _toggle;
    [SerializeField] private Door _door;
    private bool _opened;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!_opened)
        {
            if (collision.CompareTag(TagType.Player.ToString()) && _toggle.State)
            {
                _opened = true;
                StartCoroutine(WaitTillAnimEnd());
            }
        }
    }

    private IEnumerator WaitTillAnimEnd()
    {
        yield return new WaitUntil(() => _door.animEnded);
        EndLevel();
    }
}
