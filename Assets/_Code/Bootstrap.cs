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
        
        private void Awake()
        {
            InitServices();
        }
        
        private void InitServices()
        {
            _sceneService.Init();
            _triggerService.Init(_sceneService);
        }
        
    }
}