using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
   private float horizontal;
    private float speed = 32f;
    private float jumpingPower = 72f;
    private bool isFacingRight = true;
    Quaternion myRotation = Quaternion.identity;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform spriteRender;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

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
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
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
