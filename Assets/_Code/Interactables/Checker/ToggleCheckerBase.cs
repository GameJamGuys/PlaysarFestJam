using System;
using UnityEngine;

namespace _Code.Interactables.Checker
{
    public abstract class ToggleCheckerBase : MonoBehaviour
    {
        [SerializeField] protected bool _state;

        public Action checkedTrue;
        
        public abstract bool GetState();
        protected abstract void CheckState(bool state);
    }
}