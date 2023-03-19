using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Code.Interactables.Toggles
{
    public abstract class ToggleBase : MonoBehaviour
    {
        #region Private Fields
        
        [Header("Toggle")]
        [SerializeField] protected bool state;
        [SerializeField] protected bool _defaultToggleState;

        #endregion

        #region Public Events
        
        //Toggle
        public Action<bool> toggled;

        #endregion
        
        #region Public Properties

        public bool State
        {
            get => state;
            set => state = value;
        }

        #endregion
        

        //Public Methods
        public virtual void Toggle()
        {
            State = !State;
            toggled?.Invoke(State);
        }
    }
}