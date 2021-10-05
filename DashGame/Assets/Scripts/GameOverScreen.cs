using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public event Action Opened;
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _gameOverScreen;


    #region MonoBehaviour
    private void Start()
    {
        _player.Dead += Open;

    }
    #endregion

    private void Open()
    {
        _gameOverScreen.SetActive(true);
        Opened.Invoke();
    }

    private void Close()
    {
        _gameOverScreen.SetActive(false);
    }
    
    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
