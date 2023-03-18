using System;
using _Code.Data;
using UnityEngine;

namespace _Code.Interactables.Anim
{
    public class ToggleThreeSpriteAnim : MonoBehaviour
    {
        //States
        private bool _toggleState;
        private bool _turnedOn;

        [Header("Sprites")]
        [SerializeField] private Sprite _disabledSprite;
        [SerializeField] private Sprite _enabledOffSprite;
        [SerializeField] private Sprite _enabledOnSprite;
        
        [Header("Components")]
        [SerializeField] private SpriteRenderer _renderer;
        [SerializeField] private ToggleBase _toggle;

        private void OnEnable()
        {
            _toggle.toggled += SetStateBool;
        }

        private void OnDisable()
        {
            _toggle.toggled -= SetStateBool;
        }

        private void SetStateBool(bool state)
        {
            SetState(state ? ToggleState.Enabled_On : ToggleState.Enabled_Off);
        }
        
        
        public void SetState(ToggleState state)
        {
            switch (state)
            {
                case ToggleState.Disabled:
                    _renderer.sprite = _disabledSprite;
                    break;
                
                case ToggleState.Enabled_Off:
                    _renderer.sprite = _enabledOffSprite;
                    break;
                
                case ToggleState.Enabled_On:
                    _renderer.sprite = _enabledOnSprite;
                    break;
            }
        }
    }
}