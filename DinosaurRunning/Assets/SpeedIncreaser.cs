using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncreaser : MonoBehaviour
{
    public float speedMultiplier = 1f;

    public float XTime;
    float currentTime;

    private void Start()
    {
        currentTime = XTime;
    }

    private void Update()
    {
        IncreaseSpeedPerXSec();
    }

    void IncreaseSpeedPerXSec()
    {
       

        if(currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            return;
        }

        currentTime = 0;
        speedMultiplier += .1f;
        currentTime = XTime;
        Debug.Log(speedMultiplier);
      
    }
}
