using UnityEngine;

namespace _Code.Interactables.Checker
{
    public abstract class ToggleCheckerBase : MonoBehaviour
    {
        [SerializeField] protected bool _state;
        
        
        public abstract bool GetState();
    }
}