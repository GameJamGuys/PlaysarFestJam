using _Code.Data;
using UnityEngine;

namespace _Code.Interactables
{
    public class TriggerToggleSingleTag : TriggerToggleBase
    {
        [SerializeField] private TagType _tagType = TagType.Robot;
        protected override bool Check(string tag)
        {
            return tag.Equals(_tagType.ToString());
        }
    }
}