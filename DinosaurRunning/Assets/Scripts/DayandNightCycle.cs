using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class DayandNightCycle : MonoBehaviour
{
    //[SerializeField] private UnityEngine.Experimental.Rendering.;
    [SerializeField] private float reduceIntensity;

    float defaultLightIntensity; // Default Intensity

    [SerializeField] private TextMeshProUGUI[] scores;
    [SerializeField] private GameObject daySky, nightSky;

    private void Start()
    {
        //defaultLightIntensity = globalLight.intensity;

       
    }
    public void ReduceSetLightIntensity()
    {
        
       // globalLight.intensity = Mathf.Lerp(defaultLightIntensity, .2f, 1f);
    }

    public void IncreaseSetLighIntensity()
    {
        //globalLight.intensity += intensity * Time.deltaTime;
       // globalLight.intensity = Mathf.Lerp(.2f, defaultLightIntensity, 2f);

    }

    private void Update()
    {
    }

 

   public IEnumerator Enum_Intensity(float duration, bool fadeout)
    {
        float max = 1;
        float min = .3f;
        float counter = 0f;
        float a, b;

      
        if (fadeout)
        {
            a = min;
            b = max;
            daySky.SetActive(true);
            nightSky.SetActive(false);
        }
        else
        {
            a = max;
            b = min;
            daySky.SetActive(false);
            nightSky.SetActive(true);
        }


        //float currentIntenstiy = globalLight.intensity;

        while(counter < duration)
        {

            counter += Time.deltaTime;
           // globalLight.intensity = Mathf.Lerp(a, b, counter / duration);

            yield return null;
        }

        ChangeTextColor(fadeout);

    }


    void ChangeTextColor(bool condition)
    {
        if (condition == false)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i].color = Color.white;
            }
        }
        else if(condition == true)
        {

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i].color = Color.black;
            }
        }
      
    }





}
