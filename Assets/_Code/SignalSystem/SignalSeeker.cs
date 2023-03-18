using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalSeeker : MonoBehaviour
{
    public enum State { OnIdle, OnControl }
    public State state;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<SignalCircle>(out SignalCircle controller))
        {
            controller.NewUnit(this);
        }
        state = State.OnControl;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<SignalCircle>(out SignalCircle controller))
        {
            controller.RemoveUnit(this);
        }
        state = State.OnIdle;
    }
}
