using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayTime : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 1;
       
    }

    private void Start()
    {
        FindObjectOfType<AudioManagerCS>().Stop("gameover");
        FindObjectOfType<AudioManagerCS>().Play("theme");
    }
}
