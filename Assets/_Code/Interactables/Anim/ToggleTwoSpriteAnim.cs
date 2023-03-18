using System;
using UnityEngine;

namespace _Code.Interactables.Anim
{
    public class ToggleTwoSpriteAnim : MonoBehaviour
    {
        [Header("Sprites")]
        [SerializeField] private Sprite _trueSprite;
        [SerializeField] private Sprite _falseSprite;
        
        [Header("Components")]
        [SerializeField] private SpriteRenderer _renderer;
        [SerializeField] private ToggleBase _toggle;

        private void OnEnable()
        {
            _toggle.toggled += SetState;
        }

        private void OnDisable()
        {
            _toggle.toggled -= SetState;
        }

        public void SetState(bool state)
        {
            _renderer.sprite = state ? _trueSprite : _falseSprite;
        }
    }
}