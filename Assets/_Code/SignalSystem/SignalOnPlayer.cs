using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controller on Player based on signal state
public class SignalOnPlayer : MonoBehaviour
{
    [SerializeField]
    SignalCircle signal;

    [SerializeField]
    PlayerController controller;

    private void OnEnable()
    {
        signal.OnChangeControlState += CheckSignalState;
    }

    private void OnDisable()
    {
        signal.OnChangeControlState -= CheckSignalState;
    }

    void CheckSignalState(SignalCircle.ControlState state)
    {

        switch (state)
        {
            case SignalCircle.ControlState.UnitControl:
                controller.control = false;
                break;
            case SignalCircle.ControlState.OutControl:
                controller.control = true;
                break;
            default:
                return;
        }
    }
}
