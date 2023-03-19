using System;
using _Code.Characters;
using UnityEngine;

namespace _Code.SignalSystem
{
    public class RobotSignal : MonoBehaviour
    {
        [SerializeField] private CharSignal _charSignal;
        [SerializeField] private Animator anim;

        private string ANIM_CONTROL = "controlled";

        private void Start()
        {
            _charSignal.SetSignal(false);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out SignalCircle controller))
            {
                print("Seeker enter signal");
                controller.NewUnit(this);
            
                _charSignal.SetSignal(true);
                anim.SetBool(ANIM_CONTROL, true);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out SignalCircle controller))
            {
                print("Seeker exit signal");
                controller.RemoveUnit(this);
            
                _charSignal.SetSignal(false);
                anim.SetBool(ANIM_CONTROL, false);
            }
        }
    }
}
