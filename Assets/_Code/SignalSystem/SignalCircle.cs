using System;
using System.Collections.Generic;
using UnityEngine;

public class SignalCircle : MonoBehaviour
{
    [SerializeField]
    float smallRadius = 2;
    [SerializeField]
    float bigRadius = 4;

    List<SignalSeeker> seekers;

    public enum ControlState { UnitControl, OutControl}
    public event Action<ControlState> OnChangeControlState; // True if control seeker

    private void Start()
    {
        seekers = new List<SignalSeeker>();
        DecreaseRadius();
    }

    void IncreaseRadius() => ChangeRadius(bigRadius);
    void DecreaseRadius() => ChangeRadius(smallRadius);

    void ChangeRadius(float scale) => transform.localScale = new Vector3(scale, scale, 1);

    public void NewUnit(SignalSeeker unit)
    {
        if (seekers.Contains(unit)) return;

        seekers.Add(unit);
        IncreaseRadius();
        OnChangeControlState?.Invoke(ControlState.UnitControl);

        print($"{unit.name} on control");
    }

    public void RemoveUnit(SignalSeeker unit)
    {
        seekers.Remove(unit);
        print($"{unit.name} out of control");
        if (seekers.Count == 0)
        {
            DecreaseRadius();
            OnChangeControlState?.Invoke(ControlState.OutControl);
            print("No more units to control");
        }
    }
}
