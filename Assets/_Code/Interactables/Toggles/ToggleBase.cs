using System;
using UnityEngine;

namespace _Code.Interactables.Toggles
{
    public abstract class ToggleBase : MonoBehaviour
    {
        #region Private Fields

        [Header("Toggle")]
        [SerializeField] protected bool _toggleState;
        [SerializeField] protected bool _defaultToggleState;

        #endregion

        #region Public Events
        
        //Toggle
        public Action<bool> toggled;

        #endregion
        
        #region Public Properties

        public bool ToggleState
        {
            get => _toggleState;
            set => _toggleState = value;
        }

        #endregion
        

        //Public Methods
        public virtual void Toggle()
        {
            ToggleState = !ToggleState;
            toggled?.Invoke(ToggleState);
        }
    }
}