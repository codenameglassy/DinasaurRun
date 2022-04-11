using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howtoplay : MonoBehaviour
{
    [SerializeField] private GameObject howtoplayView;

    bool toggle;

    private void Start()
    {
        howtoplayView.SetActive(false);
    }

    public void HTP()
    {
        toggle = !toggle;
        if (toggle)
        {
            howtoplayView.SetActive(true);
            //Time.timeScale = 0;
        }
        else if (!toggle)
        {
            //Time.timeScale = 1;
            howtoplayView.SetActive(false);
        }
    }
}
