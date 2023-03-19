using System;
using _Code.Interactables.Toggles;
using UnityEngine;

namespace _Code.Audio
{
    public class ToggleAudio : MonoBehaviour
    {
        [SerializeField] private AudioClip _sound;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private ToggleBase _toggle;

        private void OnEnable()
        {
            _toggle.toggled += OnToggle;
        }
        
        private void OnDisable()
        {
            _toggle.toggled -= OnToggle;
        }

        private void OnToggle(bool state)
        {
            _audioSource.PlayOneShot(_sound);
        }
    }
}