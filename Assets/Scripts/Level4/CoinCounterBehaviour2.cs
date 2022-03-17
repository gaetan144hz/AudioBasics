using TMPro;
using UnityEngine;

public class CoinCounterBehaviour2 : MonoBehaviour
{
    private TextMeshProUGUI textMeshProUGUI;

    private void Awake()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    public void ChangeCounter(int counter)
    {
        textMeshProUGUI.text = counter.ToString();
    }
}