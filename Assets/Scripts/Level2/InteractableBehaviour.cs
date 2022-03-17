using UnityEngine;

public class InteractableBehaviour : MonoBehaviour
{
    private IInteractable interactable;
    private InteractableActivator activator;

    private void Awake()
    {
        interactable = GetComponent<IInteractable>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        activator = col.GetComponent<InteractableActivator>();
        activator.SetInteractable(interactable);
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        activator = col.GetComponent<InteractableActivator>();
        activator.RemoveInteractable(interactable);
    }
}
