using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
   private float horizontal;
    private float speed = 32f;
    private float jumpingPower = 64f;
    private bool isFacingRight = true;
    Quaternion myRotation = Quaternion.identity;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private CapsuleCollider2D cc;
    [SerializeField] private Transform spriteRender;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask deathLayer;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (horizontal < 0)
        {
            myRotation.eulerAngles = new Vector3(0, 0, 10);
        }
        else if (horizontal > 0)
        {
            myRotation.eulerAngles = new Vector3(0, 0, -10);
        }
        else
        {
            myRotation.eulerAngles = new Vector3(0, 0, 0);
        }
        spriteRender.rotation = myRotation;

        if (Input.GetKeyDown(KeyCode.W) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetKeyUp(KeyCode.W) && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();
        isdead();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 5f, groundLayer);
    }

    private void isdead()
    {
        if (Physics2D.OverlapCapsule(rb.position - new Vector2(0.3f,0), new Vector2(5.01f, 10.01f), CapsuleDirection2D.Vertical, 0, deathLayer))
        {
            rb.position = new Vector2(-649, -20);
        }
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
