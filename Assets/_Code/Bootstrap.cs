using System;
using _Code.Services;
using _Code.Services.Interfaces;
using UnityEngine;

namespace _Code
{
    public class Bootstrap : MonoBehaviour
    {
        //Services
        [SerializeField] private SceneService _sceneService;
        [SerializeField] private TriggerService _triggerService;
        [SerializeField] private ElectroService _electroService;
        
        private void Awake()
        {
            InitServices();
        }
        
        private void InitServices()
        {
            _sceneService.Init();
            _triggerService.Init(_sceneService);
            _electroService.Init();
        }
        
    }
}