using UnityEngine;
using UnityEngine.Events;

public class CoinCollector4 : MonoBehaviour
{
    public UnityEvent<int> onCoinCollected;
    public UnityEvent allCoinsCollected;

    [HideInInspector] public int counter;

    public void IncrementCount()
    {
        counter++;
        onCoinCollected.Invoke(counter);
        if (counter >= 4)
            allCoinsCollected.Invoke();
    }
}
