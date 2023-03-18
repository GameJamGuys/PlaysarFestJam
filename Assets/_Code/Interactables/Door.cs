using System;
using _Code.Data;
using _Code.Interactables.Checker;
using UnityEngine;

namespace _Code.Interactables
{
    public class Door : MonoBehaviour
    {
        private bool _state;

        [Header("Sounds")]
        [SerializeField] private AudioClip _doorOpenSound;
        
        [Header("Components")] 
        [SerializeField] private Animator _animator;
        [SerializeField] private AudioSource _audioSource;
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
            _audioSource.PlayOneShot(_doorOpenSound);
            _animator.SetBool(Active, state);
        }
    }
}