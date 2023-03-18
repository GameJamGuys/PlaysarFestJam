namespace _Code.Interactables
{
    /// <summary>
    /// Toggles on/off infinite number of times
    /// </summary>
    public class ToggleInfinite : ToggleBase
    {
        public override void Toggle()
        {
            State = !State;
        }
    }
}