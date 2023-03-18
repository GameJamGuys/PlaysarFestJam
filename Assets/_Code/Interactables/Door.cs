using System;
using _Code.Data;
using _Code.Interactables.Checker;
using UnityEngine;
using UnityEngine.Serialization;

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
        [SerializeField] private ToggleCheckerBase _toggleCheckerBase;
        
        //Anim
        private static readonly int Active = Animator.StringToHash("active");
        
        public bool animEnded;
        private bool _opened;

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
            if (!_opened)
            {
                if (_toggleCheckerBase.GetState())
                {
                    _state = state;
                    SetAnim(state);
                }
            }
        }

        private void SetAnim(bool state)
        {
            _audioSource.PlayOneShot(_doorOpenSound);
            _animator.SetBool(Active, state);
            _opened = true;
        }

        public void OnAnimEnded()
        {
            animEnded = true;
        }
    }
}