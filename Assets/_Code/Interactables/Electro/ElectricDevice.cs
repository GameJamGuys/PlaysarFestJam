using System;
using _Code.Services.Interfaces;
using UnityEngine;

namespace _Code.Interactables.Electro
{
    public class ElectricDevice : MonoBehaviour
    {
        //State
        private bool _state;
        public bool State => _state;

        public Action<bool> changed;
        
        //Services
        private IElectroService _electroService;

        
        
        public void Init(IElectroService electroService)
        {
            _electroService = electroService;
        }
        
        public void SetState(bool state)
        {
            _state = state;
        }
    }
}