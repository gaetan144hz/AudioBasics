using TMPro;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public GameObject chest;

    private int counter;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag("Coin"))
            return;

        counter++;
        coinText.text = counter.ToString();
        if(counter >= 4)
            chest.SetActive(true);
        Destroy(col.gameObject);
    }
}
