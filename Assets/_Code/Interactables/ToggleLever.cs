namespace _Code.Interactables
{
    /// <summary>
    /// Toggles on/off infinite number of times
    /// </summary>
    public class ToggleLever : ToggleBase
    {
        public override void Toggle()
        {
            State = !State;
        }
    }
}