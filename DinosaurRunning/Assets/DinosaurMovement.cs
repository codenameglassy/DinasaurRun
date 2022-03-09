using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurMovement : MonoBehaviour
{
    [Space]
    [Header("Components")]
    private Rigidbody2D rb;
    CharacterController2D characterController;

    [Space]
    [Header("Movement")]
    public float Speed;
    Vector2 movement;
    bool isAlive = true;
    float facingDir = 1;
    bool isJumping = false;
    public Transform groundCheckPos;
    bool isGrounded;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

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

        CheckSurroundings();
         
        Jump();
    }

    private void FixedUpdate()
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
        characterController.Move(facingDir * Speed * Time.deltaTime, false, jump);
    }

    

    bool jump;
    void Jump()
    {
        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }

        if (!isGrounded)
        {
            return;
        }

        if (isJumping)
        {
            return;
        }

        isJumping = true;

        jump = true;

    }

    void CheckSurroundings()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPos.position, groundCheckRadius, whatIsGround);

       
    }

    public void OnLand()
    {
        isJumping = false;
        jump = false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheckPos.position, groundCheckRadius);
    }
}
