using System;
using _Code.Interactables.Toggles;
using UnityEngine;

namespace _Code.Interactables.Anim
{
    public class ToggleLoopAnim : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private Animator _animator;
        [SerializeField] private ToggleBase _toggle;
        
        //Anim
        private static readonly int Active = Animator.StringToHash("Active");

        private void OnEnable()
        {
            _toggle.toggled += SetState;
        }
        
        private void OnDisable()
        {
            _toggle.toggled -= SetState;
        }

        private void SetState(bool state)
        {
            _animator.SetBool(Active, state);
        }
    }
}