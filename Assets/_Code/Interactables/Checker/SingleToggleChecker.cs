using System;
using _Code.Interactables.Toggles;
using UnityEngine;

namespace _Code.Interactables.Checker
{
    public class SingleToggleChecker : ToggleCheckerBase
    {
        [SerializeField] private ToggleBase _toggle;

        protected void OnEnable()
        {
            _toggle.toggled += CheckState;
        }

        protected void OnDisable()
        {
            _toggle.toggled -= CheckState;
        }

        public override bool GetState()
        {
            return _toggle.State;
        }

        protected override void CheckState(bool state)
        {
            if (_toggle.State)
            {
                checkedTrue?.Invoke();
            }
        }
    }
}