using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int TotalCoins { get; private set; }

    private void Update()
    {
        transform.Rotate(0, 360 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Sphere sphere = other.GetComponent<Sphere>();

        AddCoin();
    }

    private void AddCoin()
    {
        TotalCoins++;
        Debug.Log($"Собрано монет: {TotalCoins}");
        gameObject.SetActive(false);
    }
}
