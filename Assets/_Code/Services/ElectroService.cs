using System;
using _Code.Interactables.Electro;
using _Code.Interactables.Panel;
using _Code.Services.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Code.Services
{
    public class ElectroService : MonoBehaviour, IElectroService
    {
        #region Private Fields

        private Action<bool> _electrified;
        [SerializeField] private ElectricDevice[] _devices;
        [SerializeField] private ElectroPanel _panel;

        #endregion
        
        #region Public Properties

        public Action<bool> electrified
        {
            get => _electrified;
            set => _electrified = value;
        }
        public ElectricDevice[] Devices => _devices;

        #endregion


        public void Init()
        {
            foreach (var device in _devices)
            {
                device.Init(this);
                _panel.Init(this, _devices);
            }
        }
    }
}