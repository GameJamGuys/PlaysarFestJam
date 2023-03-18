using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Code.SignalSystem
{
    public class SignalCircle : MonoBehaviour
    {
        [SerializeField] private float smallRadius;
        [SerializeField] private float bigRadius;

        private List<RobotSignal> seekers;
        public event Action<bool> OnChangeControlState; // True if control seeker

        private void Start()
        {
            seekers = new List<RobotSignal>();
            DecreaseRadius();
        }

        void IncreaseRadius() => ChangeRadius(bigRadius);
        void DecreaseRadius() => ChangeRadius(smallRadius);

        void ChangeRadius(float scale) => transform.localScale = new Vector3(scale, scale, 1);

        public void NewUnit(RobotSignal unit)
        {
            if (seekers.Contains(unit)) return;

            seekers.Add(unit);
            IncreaseRadius();
            OnChangeControlState?.Invoke(true);

            print($"{unit.name} on control");
        }

        public void RemoveUnit(RobotSignal unit)
        {
            seekers.Remove(unit);
            print($"{unit.name} out of control");
            if (seekers.Count == 0)
            {
                DecreaseRadius();
                OnChangeControlState?.Invoke(false);
                print("No more units to control");
            }
        }
    }
}
