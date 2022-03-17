using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InteractableActivator2 : MonoBehaviour
{
    public UnityEvent onInteract;

    public void OnInteract(InputAction.CallbackContext obj)
    {
        if(obj.performed)
            onInteract?.Invoke();
    }
}
