using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    [Header("Gui")]
    public TextMeshProUGUI currentScoreTxt;
    public TextMeshProUGUI highScoreTxt;
    public TextMeshProUGUI coinTxt;

    [Header("Pause_Gui")]
    public TextMeshProUGUI Pause_currentScoreTxt;
    public TextMeshProUGUI Pause_highScoreTxt;
    public TextMeshProUGUI Pause_coinTxt;

    [Header("gameOver_Gui")]
    public TextMeshProUGUI gameOver_currentScoreTxt;
    public TextMeshProUGUI gameOver_highScoreTxt;
    public TextMeshProUGUI gameOver_coinTxt;


    private float currentScore = 0;
    private float curretCoin;
    
    [HideInInspector] public float playedTime;
    bool fetch = true;


    private void Awake()
    {
        currentScore = 0;
        curretCoin = PlayerPrefs.GetFloat("coin");


    }
    private void Start()
    {
        if (currentScoreTxt != null)
            currentScoreTxt.text = currentScore.ToString("0");

        if (Pause_currentScoreTxt != null)
            Pause_currentScoreTxt.text = currentScore.ToString("0");

        if (gameOver_currentScoreTxt != null)
            gameOver_currentScoreTxt.text = currentScore.ToString("0");

      

        if (coinTxt.text != null)
            coinTxt.text = PlayerPrefs.GetFloat("coin").ToString();

        if (Pause_coinTxt != null)
            Pause_coinTxt.text = PlayerPrefs.GetFloat("coin").ToString();

        if (gameOver_coinTxt != null)
            gameOver_coinTxt.text = PlayerPrefs.GetFloat("coin").ToString();

    }


    public void AddScore(float amount)
    {
        currentScore = amount;
        scoreApiManager.AddScore((int)amount);

        if (currentScoreTxt != null)
            currentScoreTxt.text = currentScore.ToString("0");

        if (Pause_currentScoreTxt != null)
            Pause_currentScoreTxt.text = currentScore.ToString("0");

        if (gameOver_currentScoreTxt != null)
            gameOver_currentScoreTxt.text = currentScore.ToString("0");

    }

    public void AddCoin(float amount)
    {
       
        curretCoin += amount;
        PlayerPrefs.SetFloat("coin", curretCoin);
        //PlayerPrefs.SetFloat("coin", PlayerPrefs.GetFloat("coin") + amount);

        if (coinTxt.text != null)
            coinTxt.text = curretCoin.ToString();

        if (Pause_coinTxt != null)
            Pause_coinTxt.text = curretCoin.ToString();

        if (gameOver_coinTxt != null)
            gameOver_coinTxt.text = curretCoin.ToString();
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
            highScoreTxt.text = scoreApiManager.highScore.ToString("0");

        if (Pause_highScoreTxt != null)
            Pause_highScoreTxt.text = scoreApiManager.highScore.ToString("0");


        if (gameOver_highScoreTxt != null)
            gameOver_highScoreTxt.text = scoreApiManager.highScore.ToString("0");


    }

    private void updateHighScore()
    {
        scoreApiManager.ResetScore();
    }

}
