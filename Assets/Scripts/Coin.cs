using UnityEngine;

public class Coin : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0, 360 * Time.deltaTime, 0);
    }
}
