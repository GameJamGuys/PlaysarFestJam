namespace _Code.Interactables
{
    /// <summary>
    /// Toggles once
    /// </summary>
    public class ToggleOnce : ToggleBase
    {
        protected bool _toggled;

        private void Start()
        {
            State = _defaultState;
        }

        public override void Toggle()
        {
            if (!_toggled)
            {
                _toggled = true;
                State = !State;
            }
        }
    }
}