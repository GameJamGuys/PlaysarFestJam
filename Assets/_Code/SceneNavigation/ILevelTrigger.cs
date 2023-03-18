using System.Collections;
using System.Collections.Generic;
using _Code.Services.Interfaces;
using UnityEngine;

public interface ILevelTrigger
{
    public void Init(ITriggerService triggerService);
    public void EndLevel();
    public void FailLevel();
}
