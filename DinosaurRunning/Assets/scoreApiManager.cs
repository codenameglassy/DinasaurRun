using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using RamailoGames;

public class scoreApiManager : MonoBehaviour
{
    public static int currentScore = 0;
    public static int highScore = 0;

    public static event UnityAction OnScoreUpdate;

    internal static void SubmitScore(float playtime)
    {
        ScoreAPI.SubmitScore(currentScore, (int)playtime, (bool s, string msg) => { });
        Debug.Log("scoreSumbitted");
    }

    internal static void AddScore(int amount)
    {
        currentScore += amount;
        if (currentScore > highScore)
        {
            highScore = currentScore;
        }
        OnScoreUpdate?.Invoke();
    }

    

    internal static void UpdateHighScore(UnityAction callback)
    {
        ScoreAPI.GetData((bool s, Data_RequestData d) => {
            if (s)
            {
                highScore = d.high_score;
                callback?.Invoke();
            }
        });
    }

    public void ResetHighScore()
    {
        highScore = 0;

        OnScoreUpdate?.Invoke();
    }

    internal static void ResetScore()
    {
        currentScore = 0;
        PlayerPrefs.SetInt("highscore" + Application.productName, 0);
    }
}
