using UnityEngine;

public class ChestBehaviour : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        GetComponent<Animator>().SetTrigger("Open");
    }
}
