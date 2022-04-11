using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceManager : MonoBehaviour
{
    [SerializeField] private Transform player;
    scoreManager scoreManager;
    private float distance = 0;

    private void Awake()
    {
        scoreManager = FindObjectOfType<scoreManager>();
    }
    private void Start()
    {
        distance = 0;

        InvokeRepeating("SubmitToScoreManager", 1f, .5f);
    }

    void SubmitToScoreManager()
    {
        scoreManager.AddScore(distance);
    }
    
    private void Update()
    {
        CountDistance();
    }
    void CountDistance()
    {
        distance = player.position.x;
        Debug.Log(distance.ToString("0"));
    }


}
