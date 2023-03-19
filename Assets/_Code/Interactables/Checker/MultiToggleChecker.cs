using System;
using _Code.Interactables.Toggles;
using UnityEngine;

namespace _Code.Interactables.Checker
{
    public class MultiToggleChecker : ToggleCheckerBase
    {
        [SerializeField] private ToggleBase[] _toggles;

        private void OnEnable()
        {
            foreach (var toggle in _toggles)
            {
                toggle.toggled += CheckState;
            }
        }
        private void OnDisable()
        {
            foreach (var toggle in _toggles)
            {
                toggle.toggled -= CheckState;
            }
        }

        public override bool GetState()
        {
            foreach (var toggle in _toggles)
            {
                if (!toggle.State)
                {
                    return false;
                }
            }

            return true;
        }

        protected override void CheckState(bool state)
        {
            var result = true;
            
            foreach (var toggle in _toggles)
            {
                if (!toggle.State)
                {
                    result = false;
                    break;
                }
            }

            if (result)
            {
                checkedTrue?.Invoke();
            }
        }
    }
}