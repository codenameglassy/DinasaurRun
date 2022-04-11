using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncreaser : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            //FindObjectOfType<scoreManager>().AddScore(10f);
        }
    }
}
