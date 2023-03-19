namespace _Code.UI
{
    public class SpriteButton : ButtonBase
    {
        
        protected void OnMouseDown()
        {
            _onClick?.Invoke();
        }
    }
}