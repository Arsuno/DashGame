using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTimer : MonoBehaviour
{
    [SerializeField] private float _staminaTime;
    [SerializeField] private Player _player;
    [SerializeField] private float test;
    private float _currentStaminaTime;

    private void Start()
    {
        _currentStaminaTime = _staminaTime;
    }
    private void Update()
    {
        test = _currentStaminaTime;
        if (_currentStaminaTime > 0)
            _currentStaminaTime -= Time.deltaTime;
        else
            _player.Kill();
    }
    
    public void AddTime(float value)
    {
        if (_currentStaminaTime + value > _staminaTime)
        {
            _currentStaminaTime = _staminaTime;
        }
        else
        {
            _currentStaminaTime += value;
        }
    }
}
