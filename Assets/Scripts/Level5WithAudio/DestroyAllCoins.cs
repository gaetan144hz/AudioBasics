using UnityEngine;
using UnityEngine.InputSystem;

public class DestroyAllCoins : MonoBehaviour
{
    public void OnDestroyCoins(InputAction.CallbackContext context)
    {
        if(!context.performed)
            return;

        var coins = FindObjectsOfType<CoinBehaviour3>();
        foreach (var coin in coins)
        {
            Destroy(coin.gameObject);
        }

        /*
        var coins = GameObject.FindGameObjectsWithTag("Coin");
        foreach (var coin in coins)
        {
            Destroy(coin);
        }

        for (var i = 0; i < coins.Length; i++)
        {
            Destroy(coins[i]);
        }

        for (var i = 0; i < coins.Length; i += 2)
        {
            Destroy(coins[i]);
        }
        */
    }
}
