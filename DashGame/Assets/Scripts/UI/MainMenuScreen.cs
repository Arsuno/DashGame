using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScreen : MonoBehaviour
{
    [SerializeField] private AudioSource ButtonSrc;


    public void PlayButton()
    {
        ButtonSrc.Play();
        SceneManager.LoadScene("SampleScene");

    }

}
