using System.Collections;
using System.Collections.Generic;
using _Code.Services.Interfaces;
using UnityEngine;

public interface ILevelTrigger
{
    public void Init(ITriggerService triggerService);
    public void EndLevel();
    public void RestartLevel();
}

public abstract class LevelTrigger : MonoBehaviour, ILevelTrigger
{
    ITriggerService _triggerService;

    public void Init(ITriggerService triggerService)
    {
        _triggerService = triggerService;
    }

    public void EndLevel() => _triggerService.NextLevel();
    public void RestartLevel() => _triggerService.Restart();
}
