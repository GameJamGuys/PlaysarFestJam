using System;
using _Code.Data;
using UnityEngine;

namespace _Code.Interactables.Anim
{
    public class DeviceThreeSpriteAnim : MonoBehaviour
    {
        [Header("Sprites")]
        [SerializeField] private Sprite _disabledSprite;
        [SerializeField] private Sprite _enabledOffSprite;
        [SerializeField] private Sprite _enabledOnSprite;

        [Header("Components")] 
        [SerializeField] private Device _device;
        [SerializeField] private SpriteRenderer _renderer;

        private void OnEnable()
        {
            _device.changeDeviceState += SetState;
        }

        private void OnDisable()
        {
            _device.changeDeviceState -= SetState;
        }

        public void SetState(DeviceState deviceState)
        {
            switch (deviceState)
            {
                case DeviceState.Disabled:
                    _renderer.sprite = _disabledSprite;
                    break;
                
                case DeviceState.Enabled_Off:
                    _renderer.sprite = _enabledOffSprite;
                    break;
                
                case DeviceState.Enabled_On:
                    _renderer.sprite = _enabledOnSprite;
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(deviceState), deviceState, null);
            }
        }
    }
}