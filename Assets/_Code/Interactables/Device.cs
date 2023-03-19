using System;
using _Code.Data;
using _Code.Interactables.Electro;
using _Code.Interactables.Toggles;
using UnityEngine;

namespace _Code.Interactables
{
    public class Device : MonoBehaviour
    {
        [SerializeField] private ElectricDevice _electricDevice;
        [SerializeField] private ToggleBase _toggle;

        [SerializeField] private DeviceState _deviceState;

        
        //Public
        public DeviceState DeviceState => _deviceState;

        public bool State => (_electricDevice.State && _toggle.State);

        public Action<bool> changedState;
        public Action<DeviceState> changeDeviceState;

        private void OnEnable()
        {
            _electricDevice.changed += OnChangeElectroState;
            _toggle.toggled += OnChangeToggleState;
                        
            UpdateDeviceState();
        }
        private void OnDisable()
        {
            _electricDevice.changed -= OnChangeElectroState;
            _toggle.toggled -= OnChangeToggleState;
        }

        private void OnChangeToggleState(bool state)
        {
            changedState?.Invoke(State);
            UpdateDeviceState();
        }

        private void OnChangeElectroState(bool state)
        {
            changedState?.Invoke(State);
            UpdateDeviceState();
        }

        private void UpdateDeviceState()
        {
            //Electric On
            if (_electricDevice.State)
            {
                
                //On
                if (_toggle.State)
                {
                    _deviceState = DeviceState.Enabled_On;
                }
                
                //Off
                else
                {
                    _deviceState = DeviceState.Enabled_Off;
                }
            }

            //Electric Off
            else
            {
                _deviceState = DeviceState.Disabled;
            }
            
            changeDeviceState?.Invoke(_deviceState);
        }
    }
}