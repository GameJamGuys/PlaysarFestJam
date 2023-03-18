using System;
using UnityEngine;

namespace _Code.Interactables
{
    public class TriggerToggleSingleInOut : TriggerToggleSingleTag
    {
        private void OnTriggerExit2D(Collider2D other)
        {
            if (Check(other.tag))
            {
                _toggle.Toggle();
            }
        }
    }
}