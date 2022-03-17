using UnityEngine;

public class CoinBehaviour3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        var collector = col.GetComponent<CoinCollector4>();
        collector.IncrementCount();
        Destroy(gameObject);
    }
}