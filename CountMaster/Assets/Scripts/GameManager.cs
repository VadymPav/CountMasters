using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI coinsValueText;
    public static int coins;
    private void Start()
    {
        coinsValueText.text = PlayerPrefs.GetInt("Coins", 0).ToString();
        coins = PlayerPrefs.GetInt("Coins", 0);
    }
    public void IncreaseMoney()
    {
        coins++;
        PlayerPrefs.SetInt("Coins", coins);
        coinsValueText.text = PlayerPrefs.GetInt("Coins", 0).ToString();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
