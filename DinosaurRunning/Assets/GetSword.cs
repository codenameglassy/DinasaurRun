using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSword : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var Dinosaur = FindObjectOfType<DinosaurMovement>();
            if(Dinosaur.sword.active == true)
            {
                return;
            }

            Dinosaur.SetSwordState(true);
            Destroy(gameObject);
        }
    }
}
