﻿namespace _Code.Services.Interfaces
{
    public interface ITriggerService
    {
        void Init(ISceneService sceneService);
        public void Restart();
        public void NextLevel();
    }
}