using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RamailoGames;

public class startGame : MonoBehaviour
{
    private void Awake()
    {
        ScoreAPI.GameStart();
    }

    private void Start()
    {

        FindObjectOfType<AudioManagerCS>().Stop("gameover");
        FindObjectOfType<AudioManagerCS>().Play("theme");

    }
}
