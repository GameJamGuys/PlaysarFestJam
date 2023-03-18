using System;
using System.Collections.Generic;
using UnityEngine;

public class SignalCircle : MonoBehaviour
{
    List<SignalSeeker> seekers;

    public enum ControlState { UnitControl, OutControl}
    public event Action<ControlState> OnChangeControlState; // True if control seeker

    private void Start()
    {
        seekers = new List<SignalSeeker>();
    }

    void IncreaseRadius() => ChangeRadius(4);

    void DecreaseRadius() => ChangeRadius(2);

    void ChangeRadius(float scale) => transform.localScale = new Vector3(scale, scale, 1);

    public void NewUnit(SignalSeeker unit)
    {
        if (seekers.Contains(unit)) return;

        seekers.Add(unit);
        IncreaseRadius();
        OnChangeControlState?.Invoke(ControlState.UnitControl);
    }

    public void RemoveUnit(SignalSeeker unit)
    {
        seekers.Remove(unit);
        DecreaseRadius();
        OnChangeControlState?.Invoke(ControlState.OutControl);
    }
}
