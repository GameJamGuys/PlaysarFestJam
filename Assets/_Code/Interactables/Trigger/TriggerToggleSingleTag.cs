using _Code.Data;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Code.Interactables
{
    public class TriggerToggleSingleTag : TriggerToggleBase
    {
        [SerializeField] private TagType _tagType;
        protected override bool Check(string tag)
        {
            return tag.Equals(_tagType.ToString());
        }
    }
}