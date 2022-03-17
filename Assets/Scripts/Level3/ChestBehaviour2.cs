using UnityEngine;

public class ChestBehaviour2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent<InteractableActivator2>(out var activator))
        {
            activator.onInteract.AddListener(Interact);
        }
    }

    private void Interact()
    {
        GetComponent<Animator>().SetTrigger("Open");
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.TryGetComponent<InteractableActivator2>(out var activator))
        {
            activator.onInteract.RemoveListener(Interact);
        }
    }
}
