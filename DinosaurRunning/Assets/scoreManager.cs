using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    [Header("Gui")]
    public TextMeshProUGUI currentScoreTxt;
    public TextMeshProUGUI highScoreTxt;

    [Header("Pause_Gui")]
    public TextMeshProUGUI Pause_currentScoreTxt;
    public TextMeshProUGUI Pause_highScoreTxt;

    [Header("gameOver_Gui")]
    public TextMeshProUGUI gameOver_currentScoreTxt;
    public TextMeshProUGUI gameOver_highScoreTxt;


    private float currentScore;
    [HideInInspector] public float playedTime;
    bool fetch = true;

    private void Start()
    {
        if (currentScoreTxt != null)
            currentScoreTxt.text = currentScore.ToString();

        if (Pause_currentScoreTxt != null)
            Pause_currentScoreTxt.text = currentScore.ToString();

        if (gameOver_currentScoreTxt != null)
            gameOver_currentScoreTxt.text = currentScore.ToString();

    }


    public void AddScore(float amount)
    {
        currentScore += amount;
        scoreApiManager.AddScore((int)amount);

        if (currentScoreTxt != null)
            currentScoreTxt.text = currentScore.ToString();

        if (Pause_currentScoreTxt != null)
            Pause_currentScoreTxt.text = currentScore.ToString();
        
        if (gameOver_currentScoreTxt != null)
            gameOver_currentScoreTxt.text = currentScore.ToString();


    }


    private void OnEnable()
    {
        if (fetch)
            scoreApiManager.UpdateHighScore(updateScore);
        else
            updateScore();
    }

    private void updateScore()
    {
        if (highScoreTxt != null)
            highScoreTxt.text = scoreApiManager.highScore.ToString();

        if (Pause_highScoreTxt != null)
            Pause_highScoreTxt.text = scoreApiManager.highScore.ToString();


        if (gameOver_highScoreTxt != null)
            gameOver_highScoreTxt.text = scoreApiManager.highScore.ToString();


    }

    private void updateHighScore()
    {
        scoreApiManager.ResetScore();
    }

}
