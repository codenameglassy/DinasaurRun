using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseBtn : MonoBehaviour
{
    public void pause()
    {
        FindObjectOfType<pauseManager>().Pause();
    }
}
