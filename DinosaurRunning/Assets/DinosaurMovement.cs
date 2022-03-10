using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DinosaurMovement : MonoBehaviour
{
    [Space]
    [Header("Components")]
    private Rigidbody2D rb;
    CharacterController2D characterController;
    public TextMeshProUGUI playerSpeedTxt;

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
    SpeedIncreaser speedIncreaser;
    float playTime;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        characterController = GetComponent<CharacterController2D>();
        speedIncreaser = FindObjectOfType<SpeedIncreaser>();
    }

    private void Update()
    {
        if (!isAlive)
        {
            Debug.Log("Player Dead");
            return;
        }
        playTime += Time.deltaTime;
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
        PlayerSpeed();
    }

    void Move()
    {
        characterController.Move(facingDir * Speed * speedIncreaser.speedMultiplier * Time.deltaTime, false, jump);
    }

    void PlayerSpeed()
    {
        playerSpeedTxt.text = rb.velocity.x.ToString();
        Debug.Log(rb.velocity.x);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            isAlive = false;

            Debug.Log("dead");
            scoreApiManager.SubmitScore(playTime);
            Destroy(gameObject);
        }
    }


}
