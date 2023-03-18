using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalSeeker : MonoBehaviour
{
    public enum State { OnIdle, OnControll }
    public State state;


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
