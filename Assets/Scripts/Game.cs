using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private float _gameTime = 60f;
    [SerializeField] private int _coinsToWin = 5;
    [SerializeField] private Character _character;

    private float _currentTime;
    private bool _isGameActive;

    private void Awake()
    {
        StartGame();
    }

    private void Update()
    {
        if (!_isGameActive)
        {
            return;
        }

        _currentTime -= Time.deltaTime;
        UpdateTimerDisplay();

        if (_currentTime <= 0)
        {
            _currentTime = 0;
            EndGame(false);
        }

        CoinCondition();
    }

    public void StartGame()
    {
        _currentTime = _gameTime;
        _isGameActive = true;
    }

    private void CoinCondition()
    {
        if (_isGameActive == false)
        {
            return;
        }

        if (_character.CoinCollector.TotalCoins >= _coinsToWin)
        {
            EndGame(true);
        }
    }

    private void EndGame(bool isWin)
    {
        _isGameActive = false;

        if (isWin)
        {
            Debug.Log($"Вы победили!");
        }
        else
        {
            Debug.Log($"Вы проиграли! Собрано {_character.CoinCollector.TotalCoins}/{_coinsToWin} монет.");
        }
    }

    private void UpdateTimerDisplay()
    {
        Debug.Log($"Время: {Mathf.CeilToInt(_currentTime)} сек");
    }
}
