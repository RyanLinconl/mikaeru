using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public int totalScore;
    public TextMeshProUGUI scoreText; 

    public GameObject gameOver;


    public static GameController instance;

    void Start()
    {
        instance = this;
    }
    public void UpdateScoreText() 
    {
        scoreText.text = totalScore.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

}
