using System;
using _Code.Data;
using _Code.Interactables.Checker;
using UnityEngine;

namespace _Code.Interactables
{
    public class Door : MonoBehaviour
    {
        private bool _state;

        [Header("Components")] 
        [SerializeField] private Animator _animator;
        [SerializeField] private ToggleBase _toggle;
        
        //Anim
        private static readonly int Active = Animator.StringToHash("active");

        private void OnEnable()
        {
            _toggle.toggled += Toggle;
        }

        private void OnDisable()
        {
            _toggle.toggled -= Toggle;
        }

        private void Toggle(bool state)
        {
            _state = state;
            SetAnim(state);
        }

        private void SetAnim(bool state)
        {
            _animator.SetBool(Active, state);
        }
    }
}