using _Code.Data;
using _Code.Interactables.Checker;
using UnityEngine;

namespace _Code.Interactables
{
    public class Door : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private ToggleCheckerBase _checker;
    }
}