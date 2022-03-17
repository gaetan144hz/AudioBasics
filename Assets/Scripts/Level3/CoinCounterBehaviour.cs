using TMPro;
using UnityEngine;

public class CoinCounterBehaviour : MonoBehaviour
{
    private TextMeshProUGUI textMeshProUGUI;
    private CoinCollector3 coinCollector;

    private void Awake()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        var playerObject = GameObject.FindWithTag("Player");
        coinCollector = playerObject.GetComponent<CoinCollector3>();
    }

    public void ChangeCounter()
    {
        textMeshProUGUI.text = coinCollector.counter.ToString();
    }
}
