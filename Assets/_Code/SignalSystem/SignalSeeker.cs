using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalSeeker : MonoBehaviour
{
    [SerializeField]
    MonoBehaviour robotController;

    public enum State { Idle, OnControl }
    public State state;

    private void Start()
    {
        ChangeState(State.Idle);
    }

    void ChangeState(State newState)
    {
        state = newState;
        switch (state)
        {
            case State.Idle:
                robotController.enabled = false;
                break;
            case State.OnControl:
                robotController.enabled = true;
                break;
            default:
                return;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out SignalCircle controller))
        {
            print("Seeker enter signal");
            controller.NewUnit(this);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out SignalCircle controller))
        {
            print("Seeker exit signal");
            controller.RemoveUnit(this);
        }
    }
}
