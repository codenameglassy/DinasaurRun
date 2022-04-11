using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndNightChanger : MonoBehaviour
{

    DayandNightCycle cycle;
    bool change = false;
    public float cooldownTime;
    private float nextFireTime;
    private void Awake()
    {
        nextFireTime = cooldownTime;
    }
    private void Start()
    {
        cycle = GetComponent<DayandNightCycle>();
    }


    private void Update()
    {
        if(Time.time > nextFireTime)
        {
            Change();
            nextFireTime = Time.time + cooldownTime;
        }
        
    }
    void Change()
    {
        change = !change;
        if (change)
        {
            StartCoroutine(cycle.Enum_Intensity(2f, false));
        } 
        else if(!change)
        {
            StartCoroutine(cycle.Enum_Intensity(2f, true));
        }
    }
}
