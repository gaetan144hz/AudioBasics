using UnityEngine;

public class ChestBehaviour3 : MonoBehaviour
{
    private bool isTriggered;

    public void Interact()
    {
        if(isTriggered)
            GetComponent<Animator>().SetTrigger("Open");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        isTriggered = true;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        isTriggered = false;
    }
}
