using UnityEngine;
using UnityEngine.Events;

public class CoinCollector3 : MonoBehaviour
{
    public UnityEvent onCoinCollected;
    public UnityEvent allCoinsCollected;

    [HideInInspector]
    public int counter;

    public void IncrementCount()
    {
        counter++;
        onCoinCollected.Invoke();
        if (counter >= 4)
            allCoinsCollected.Invoke();
    }
}
