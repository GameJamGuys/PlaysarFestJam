using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controller on Player based on signal state
public class SignalOnPlayer : MonoBehaviour
{
    [SerializeField]
    SignalCircle signal;

    [SerializeField]
    MonoBehaviour playerController;

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
                playerController.enabled = false;
                break;
            case SignalCircle.ControlState.OutControl:
                playerController.enabled = true;
                break;
            default:
                return;
        }
    }
}
