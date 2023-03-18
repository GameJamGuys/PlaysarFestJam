using System;
using UnityEngine;

namespace _Code.Interactables.Checker
{
    public class MultiToggleChecker : ToggleCheckerBase
    {
        [SerializeField] private ToggleBase[] _toggles;
        
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
    }
}