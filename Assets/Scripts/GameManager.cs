using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject menuUI, loseUI;
    public PipeSpawner pipeSpawner;
    public CoinSpawner coinSpawner;
    public PlayerController playerController;
    public int points = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI coinText;

    public void StartGame()
    {
        menuUI.SetActive(false);
        pipeSpawner.enabled = true;
        coinSpawner.enabled = true;
        playerController.enabled = true;
        playerController.rb.simulated = true;
    }

    private void ShowLoseUI()
    {
        loseUI.SetActive(true);
    }

    public void RepeatGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void OnGameOver()
    {
        ShowLoseUI();
        Time.timeScale = 0;
    }

    public void UpdateScore()
    {
        points++;
        scoreText.text = "Points: "+points.ToString();
    }
}
