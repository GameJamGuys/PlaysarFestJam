using UnityEngine;

namespace _Code.Interactables.Checker
{
    public class SingleToggleChecker : ToggleCheckerBase
    {
        [SerializeField] private ToggleBase _toggle;
        
        public override bool GetState()
        {
            return _toggle.State;
        }
    }
}