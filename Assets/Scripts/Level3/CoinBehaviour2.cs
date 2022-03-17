using UnityEngine;

public class CoinBehaviour2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        var collector = col.GetComponent<CoinCollector3>();
        collector.IncrementCount();
        Destroy(gameObject);
    }
}
