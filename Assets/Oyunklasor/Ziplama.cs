using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ziplama : MonoBehaviour
{
    public int jumpForce = 10;
    private Rigidbody2D rb;
    private Animator animator;

    // Zıplama durumu
    private bool isJumping = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            Jump();
        }

        // Animator'a zıplama durumunu (isJumping) iletebilirsin
        animator.SetBool("isJump", isJumping);
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        // Zıplama durumunu true yap
        isJumping = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Zemin ile temas ettiğinde zıplama durumunu sıfırla
        if (collision.gameObject.CompareTag("Platform"))
        {
            isJumping = false;
        }
    }
}
