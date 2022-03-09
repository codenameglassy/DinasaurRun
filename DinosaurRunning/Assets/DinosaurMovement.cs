using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurMovement : MonoBehaviour
{
    [Space]
    [Header("Components")]
    private Rigidbody2D rb;
    Vector2 movement;
    CharacterController2D characterController;

    [Space]
    [Header("Movement")]
    public float Speed;
    bool isAlive = true;
    int facingDir = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        characterController = GetComponent<CharacterController2D>();
    }

    private void Update()
    {
        if (!isAlive)
        {
            Debug.Log("Player Dead");
            return;
        }

        Move();
    }

    void Move()
    {
        characterController.Move(facingDir * Speed * Time.deltaTime, false, false);
    }
  

}
