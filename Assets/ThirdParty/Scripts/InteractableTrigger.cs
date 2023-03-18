using _Code.Data;
using UnityEngine;

/// <summary>
/// Trigger that can be interacted with by a character by Tag
/// </summary>
[RequireComponent(typeof(TriggerObject))]
public class InteractableTrigger : InteractableObject
{
    [SerializeField] private TagType _charTag;
    private TriggerObject trigger;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        trigger = GetComponent<TriggerObject>();
    }

    /// <summary>
    /// When a character interacts with this object, toggle the trigger
    /// </summary>
    /// <param name="_system"></param>
    public override void Interact()
    {
        trigger.Trigger();
        // if it's an one shot trigger, disables the interaction
        if (trigger.oneShot)
        {
            interactable = !trigger.Active;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(_charTag.ToString()))
        {
            Interact();
        }
    }
}