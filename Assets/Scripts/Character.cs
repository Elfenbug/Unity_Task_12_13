using UnityEngine;

public class Character : MonoBehaviour
{
    public CoinCollector CoinCollector;

    private void Awake()
    {
        CoinCollector = GetComponent<CoinCollector>();
    }
}
