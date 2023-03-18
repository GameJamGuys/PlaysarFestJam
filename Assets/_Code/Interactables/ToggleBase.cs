using UnityEngine;

namespace _Code.Interactables
{
    public abstract class ToggleBase
    {
        //Private Fields
        protected bool _state;

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
        public abstract void Toggle();
    }
}