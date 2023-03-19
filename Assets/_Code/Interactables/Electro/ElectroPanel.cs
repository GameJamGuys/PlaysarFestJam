using System;
using _Code.Interactables.Electro;
using _Code.Interactables.Toggles;
using _Code.Services.Interfaces;
using UnityEngine;

namespace _Code.Interactables.Panel
{
    public class ElectroPanel : MonoBehaviour
    {
        //Private Fields
        private IElectroService _electroService;
        [SerializeField] private ElectricDevice[] _devices;

        [Header("Components")]
        [SerializeField] private ToggleBase _toggle;

        private void OnEnable()
        {
            _toggle.toggled += SetState;
        }
        
        private void OnDisable()
        {
            _toggle.toggled -= SetState;
        }
        
        public void Init(IElectroService electroService, ElectricDevice[] devices)
        {
            _electroService = electroService;
            _devices = devices;
        }

        private void Start()
        {
            SetState(false);
        }

        private void SetState(bool state)
        {
            foreach (var device in _devices)
            {
                device.SetState(state);
            }
        }
    }
}