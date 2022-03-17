using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        var collector = col.GetComponent<CoinCollector2>();
        collector.IncrementCount();
        Destroy(gameObject);
    }
}
