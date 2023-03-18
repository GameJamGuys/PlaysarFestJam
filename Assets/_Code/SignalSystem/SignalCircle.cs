using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalCircle : MonoBehaviour
{
    List<SignalSeeker> seekers;
    bool isControlling;

    private void Start()
    {
        seekers = new List<SignalSeeker>();
    }

    void ChangeSize()
    {

    }


    void NewUnit(SignalSeeker unit)
    {
        if (seekers.Contains(unit) return;

        seekers.Add(unit);
    }

    void RemoveUnit(SignalSeeker unit)
    {
        seekers.Remove(unit);
    }
}
