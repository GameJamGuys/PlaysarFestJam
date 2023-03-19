using System;
using _Code.Data;
using _Code.Interactables.Checker;
using _Code.Interactables.Devices;
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
        [SerializeField] private DeviceChecker _deviceChecker;
        [SerializeField] private BoxCollider2D _collider2D;
        
        //Anim
        private static readonly int Active = Animator.StringToHash("active");
        
        public bool animEnded;
        private bool _opened;

        private void OnEnable()
        {
            _deviceChecker.checkedWasTrue += OnOpen;
        }

        private void OnDisable()
        {
            _deviceChecker.checkedWasTrue -= OnOpen;
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

        public void OnOpen()
        {
            SetAnim(true);
            _collider2D.enabled = true;
        }
    }
}