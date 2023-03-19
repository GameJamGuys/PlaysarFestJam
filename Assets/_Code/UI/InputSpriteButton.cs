using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Code.UI
{
    public class InputSpriteButton : MonoBehaviour
    {
        [SerializeField]
        WebTouchInput touchInput;
        [SerializeField]
        public PlayerController.ButtonInputType type;

        private void OnMouseDown()
        {
            print($"{transform.name} down");
            touchInput.ButtonDown(type);
        }

        private void OnMouseUp()
        {
            print($"{transform.name} up");
            touchInput.ButtonUp(type);
        }
    }

}

