using System;
using System.Net.NetworkInformation;
using _Code.Characters;
using UnityEngine;

namespace _Code.Sound
{
    public class RobotSound : MonoBehaviour
    {
        [Header("Sounds")]
        [SerializeField] private AudioClip _signalOnSound;
        [SerializeField] private AudioClip _signalOffSound;
        private bool _firstSound = true;

        [Header("Components")]
        [SerializeField] private AudioSource _audioSource;

        [SerializeField] private CharSignal _charSignal;

        
        
        private void OnEnable()
        {
            _charSignal.settedSignal += OnSignalSet;
        }

        private void OnDisable()
        {
            _charSignal.settedSignal -= OnSignalSet;
        }

        public void OnSignalSet(bool state)
        {
            if (!_firstSound)
            {
                var sound = state ? _signalOnSound : _signalOffSound;
                _audioSource.PlayOneShot(sound);
            }

            else
            {
                _firstSound = false;
            }
        }
    }
}