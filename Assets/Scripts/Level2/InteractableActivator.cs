using UnityEngine;
using UnityEngine.InputSystem;

public class InteractableActivator : MonoBehaviour
{
    private IInteractable lastInteractable;

    public void SetInteractable(IInteractable newInteractable)
    {
        lastInteractable = newInteractable;
    }

    public void RemoveInteractable(IInteractable oldInteractable)
    {
        if (lastInteractable == oldInteractable)
            lastInteractable = null;
    }

    public void OnInteraction(InputAction.CallbackContext obj)
    {
        if(!obj.performed || lastInteractable == null)
            return;
        lastInteractable.Interact();
    }
}
