using System;
using UnityEngine;

namespace _Code.Characters
{
    
    //Sets on/off control of Character
    public class CharSignal : MonoBehaviour
    {
        //Deserialized private fields
        private bool _state;
        
        //Serialized Private Fields
        [SerializeField] private PlayerController _controller;
        
        //Public properties
        public bool State => _state;
        
        //Public Events
        public Action<bool> settedSignal;


        public void SetSignal(bool state)
        {
            settedSignal?.Invoke(state);
            _controller.SetControls(state);
        }
    }
}