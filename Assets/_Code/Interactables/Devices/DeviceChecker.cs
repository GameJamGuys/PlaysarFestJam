using System;
using UnityEngine;

namespace _Code.Interactables.Devices
{
    public class DeviceChecker : MonoBehaviour
    {
        [SerializeField] private Device[] _devices;
        
        public Action checkedWasTrue;

        private void OnEnable()
        {
            foreach (var device in _devices)
            {
                device.changedState += CheckState;
            }
        }
        
        private void OnDisable()
        {
            foreach (var device in _devices)
            {
                device.changedState -= CheckState;
            }
        }
        

        private void CheckState(bool state)
        {
            var result = true;
            
            foreach (var device in _devices)
            {
                if (!device.State)
                {
                    result = false;
                    break;
                }
            }

            if (result)
            {
                checkedWasTrue?.Invoke();
            }
        }
    }
}