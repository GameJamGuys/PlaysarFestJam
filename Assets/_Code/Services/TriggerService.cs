﻿using _Code.Services.Interfaces;
using UnityEngine;

namespace _Code.Services
{
    public class TriggerService : MonoBehaviour, ITriggerService
    {
        [SerializeField]
        LevelTrigger[] levelTriggers;
        //Services
        private ISceneService _sceneService;
        
        public void Init(ISceneService sceneService)
        {
            _sceneService = sceneService;

            foreach(ILevelTrigger trigger in levelTriggers)
            {
                trigger.Init(this);
            }
        }

        public void Restart()
        {
            _sceneService.Restart();
        }

        public void NextLevel()
        {
            _sceneService.NextLevel();
        }
    }
}