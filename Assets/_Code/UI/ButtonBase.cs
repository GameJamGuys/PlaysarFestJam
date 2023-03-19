using System;
using UnityEngine;
using UnityEngine.Events;

namespace _Code.UI
{
    public class ButtonBase : MonoBehaviour
    {
        [SerializeField] protected UnityEvent _onClick;
    }
}