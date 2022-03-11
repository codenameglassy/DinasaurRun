using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject coinCollectFx;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<scoreManager>().AddScore(20f);
            Instantiate(coinCollectFx, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
