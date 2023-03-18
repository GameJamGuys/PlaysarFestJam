using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILevelTrigger
{
    public abstract void Init();
    public abstract void EndLevel();
    public abstract void FailLevel();
}
