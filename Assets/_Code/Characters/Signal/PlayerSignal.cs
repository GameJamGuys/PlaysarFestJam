using _Code.Characters;
using _Code.SignalSystem;
using UnityEngine;

// Controller on Player based on signal state
public class PlayerSignal : MonoBehaviour
{ 
    [Header("Components")]
    [SerializeField] private SignalCircle _circleSignal;
    [SerializeField] private CharSignal _charSignal;

    private void OnEnable()
    {
        _circleSignal.OnChangeControlState += CheckCircleSignalState;
    }

    private void OnDisable()
    {
        _circleSignal.OnChangeControlState -= CheckCircleSignalState;
    }

    private void CheckCircleSignalState(bool state)
    {
        _charSignal.SetSignal(!state);
    }
}
