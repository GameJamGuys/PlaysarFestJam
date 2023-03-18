namespace _Code.Interactables
{
    /// <summary>
    /// Toggles once
    /// </summary>
    public class ToggleButton : ToggleBase
    {
        protected bool _toggled;

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