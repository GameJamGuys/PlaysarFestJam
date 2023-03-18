using System;
using UnityEngine;

namespace _Code.Interactables
{
    public abstract class TriggerToggleBase : MonoBehaviour
    {
        protected ToggleBase _toggle;

        protected abstract bool Check(string tag);

        protected void OnTriggerEnter2D(Collider2D col)
        {
            if (Check(col.tag))
            {
                _toggle.Toggle();
            }
        }
    }
}