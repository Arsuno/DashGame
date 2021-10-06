using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOverDisplay : MonoBehaviour
{
    [SerializeField] private Text _scoreLabel;
    [SerializeField] private GameOverScreen _gameOverScreen;
    [SerializeField] private Score _score;

    private void OnEnable()
    {
        _gameOverScreen.Opened += DisplayScore;
    }

    private void OnDisable()
    {
        _gameOverScreen.Opened -= DisplayScore;
    }

    private void DisplayScore()
    {
        _scoreLabel.text = _score.Value.ToString();
    }
}
