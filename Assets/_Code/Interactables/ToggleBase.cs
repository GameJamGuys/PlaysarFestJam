using System;
using UnityEngine;

namespace _Code.Interactables
{
    public abstract class ToggleBase : MonoBehaviour
    {
        //Private Fields
        protected bool _state;
        
        //Actions
        public Action<bool> toggled;

        public bool State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }
        [SerializeField] protected bool _defaultState;

        //Public Methods
        public virtual void Toggle()
        {
            toggled?.Invoke(_state);
        }
    }
}