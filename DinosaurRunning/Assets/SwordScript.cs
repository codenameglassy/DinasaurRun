using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    public GameObject enemyBloodFx;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            FindObjectOfType<scoreManager>().AddScore(20f);
            Instantiate(enemyBloodFx, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
        }
    }
}
