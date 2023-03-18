﻿using _Code.Services.Interfaces;
using UnityEngine;

namespace _Code.Services
{
    public class TriggerService : MonoBehaviour, ITriggerService
    {
        //Services
        private ISceneService _sceneService;
        
        public void Init(ISceneService sceneService)
        {
            
        }

        public void OnRestart()
        {
            _sceneService.Restart();
        }
    }
}