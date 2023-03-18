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


        public void SetSignal(bool state)
        {
            _controller.SetControls(state);
        }
    }
}