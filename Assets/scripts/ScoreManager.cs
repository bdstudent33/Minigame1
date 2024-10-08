using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Start()
    {
        UpdateScoreText();
    }

    public void IncrementScore()
    {
        score++;
        UpdateScoreText();

      
        if (score >= 10)
        {
            EndGame();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void EndGame()
    {
        
        Debug.Log("You Win!");

       
        Time.timeScale = 0;
    }
}