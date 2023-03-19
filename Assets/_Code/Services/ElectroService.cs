using System;
using _Code.Interactables.Electro;
using _Code.Services.Interfaces;
using UnityEngine;

namespace _Code.Services
{
    public class ElectroService : MonoBehaviour, IElectroService
    {
        #region Private Fields

        private Action<bool> _electrified;
        [SerializeField] private ElectricDevice[] _electricDevices;

        #endregion
        
        #region Public Properties

        public Action<bool> electrified
        {
            get => _electrified;
            set => _electrified = value;
        }
        public ElectricDevice[] ElectricDevices => _electricDevices;

        #endregion


        private void Awake()
        {
            foreach (var device in _electricDevices)
            {
                device.Init(this);
            }
        }
    }
}