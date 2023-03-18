using System;
using System.Collections;
using _Code.Data;
using _Code.Interactables;
using _Code.Interactables.Checker;
using UnityEngine;
using UnityEngine.Serialization;

public class EndLevelTrigger : LevelTrigger
{
    [SerializeField] private ToggleCheckerBase _toggleChecker;
    [SerializeField] private Door _door;
    
    private bool _opened;
    private bool _entered;
    
    //
    private IEnumerator _lastCoroutine;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(TagType.Player.ToString()))
        {
            _entered = true;
            if (!_opened)
            {
                if (_toggleChecker.GetState())
                {
                    _lastCoroutine = WaitTillAnimEnd();
                    StartCoroutine(_lastCoroutine);
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (_entered && other.CompareTag(TagType.Player.ToString()))
        {
            _entered = false;
            if (_lastCoroutine != null)
            {
                StopCoroutine(WaitTillAnimEnd());
                _lastCoroutine = null;
            }
        }
    }

    private IEnumerator WaitTillAnimEnd()
    {
        yield return new WaitUntil(() => _door.animEnded);
        _opened = true;
        yield return new WaitUntil(() => _entered);
        EndLevel();
    }
}
