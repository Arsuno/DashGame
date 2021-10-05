using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;

    private int _score = 0;

    private void Start()
    {
        _scoreText.text = _score.ToString();
    }

    public void AddPoint()
    {
        _score += 1;
        _scoreText.text = _score.ToString();
    }
}
