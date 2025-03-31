using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int TotalCoins { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        Coin coin = other.GetComponent<Coin>();

        if (coin != null)
        {
            AddCoin(coin);
        }
    }

    public void AddCoin(Coin coin)
    {
        TotalCoins++;
        coin.gameObject.SetActive(false);
        Debug.Log($"Собрано монет: {TotalCoins}");
    }
}
