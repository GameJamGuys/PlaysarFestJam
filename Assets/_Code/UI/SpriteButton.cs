using System;
using UnityEngine;

namespace _Code.UI
{
    public class SpriteButton : ButtonBase
    {
        [Header("Sprites")]
        [SerializeField] private Sprite _idleSprite;
        [SerializeField] private Sprite _howerSprite;

        [Header("Components")] 
        [SerializeField] private SpriteRenderer _renderer;

        private void OnEnable()
        {
            _renderer.sprite = _idleSprite;
        }

        protected void OnMouseDown()
        {
            _renderer.sprite = _idleSprite;
            _onClick?.Invoke();
        }

        protected void OnMouseEnter()
        {
            _renderer.sprite = _howerSprite;
        }

        protected void OnMouseExit()
        {
            _renderer.sprite = _idleSprite;
        }
    }
}