using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public event Action<int> ScoreChanged;
    public int Value => _value;

    private int _value = 0;

    public void Add(int amount)
    {
        _value += amount;
        ScoreChanged.Invoke(_value);
    }
}
