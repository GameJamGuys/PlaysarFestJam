using System;
using _Code.Characters;
using UnityEngine;

namespace _Code.Sound
{
    public class RobotSound : MonoBehaviour
    {
        [Header("Sounds")]
        [SerializeField] private AudioClip _signalOnSound;
        [SerializeField] private AudioClip _signalOffSound;

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
            var sound = state ? _signalOnSound : _signalOffSound;
            _audioSource.PlayOneShot(sound);
        }
    }
}