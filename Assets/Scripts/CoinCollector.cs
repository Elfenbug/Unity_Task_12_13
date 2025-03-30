using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public static int TotalCoins { get; private set; }

    public void AddCoins()
    {
        TotalCoins++;
        Debug.Log($"Собрано монет: {TotalCoins}");
    }
}
