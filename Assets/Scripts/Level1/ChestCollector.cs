using UnityEngine;
using UnityEngine.InputSystem;

public class ChestCollector : MonoBehaviour
{
    private GameObject lastTriggeredObject;

    public void OnInteraction(InputAction.CallbackContext obj)
    {
        if(!obj.performed || lastTriggeredObject == null)
            return;
        lastTriggeredObject.GetComponent<Animator>().SetTrigger("Open");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag("Chest"))
            return;
        lastTriggeredObject = col.gameObject;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (!col.CompareTag("Chest"))
            return;
        lastTriggeredObject = null;
    }
}
