using System;
using _Code.Services.Interfaces;
using UnityEngine;

namespace _Code.Interactables.Electro
{
    public class ElectricDevice : MonoBehaviour
    {
        //State
        [SerializeField] private bool _defaultState;
        [SerializeField] private bool _state;
        public bool State => _state;

        public Action<bool> changed;
        
        //Services
        private IElectroService _electroService;

        
        
        public void Init(IElectroService electroService)
        {
            _electroService = electroService;
        }

        private void Awake()
        {
            _state = _defaultState;
        }

        public void SetState(bool state)
        {
            _state = state;
            changed?.Invoke(_state);
        }
    }
}