using TMPro;
using UnityEngine;

public class CoinCollector2 : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public GameObject chest;

    private int counter;

    public void IncrementCount()
    {
        counter++;
        coinText.text = counter.ToString();
        if (counter >= 4)
            chest.SetActive(true);
    }
}
