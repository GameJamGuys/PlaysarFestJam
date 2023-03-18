using _Code.Data;
using UnityEngine;

namespace _Code.Interactables
{
    public class TriggerToggleMultiTag : TriggerToggleBase
    {
        [SerializeField] private TagType[] _tagsTypes;
        
        protected override bool Check(string tag)
        {
            foreach (var tagType in _tagsTypes)
            {
                if (tagType.ToString().Equals(tag))
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}