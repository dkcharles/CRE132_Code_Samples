using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2D => GetComponent<Rigidbody2D>();
    [SerializeField] float jumpForce;
    [SerializeField] Vector2 groundCheckDimensions;
    [SerializeField] LayerMask platformLayer;
    [SerializeField] float movementSpeed;

    float horizontalInput;
    public bool isGrounded;
    void Start()
    {
        Application.targetFrameRate = 50;
    }
    void Update()
    {
        CheckForGround();
    }

    private void FixedUpdate()
    {
        rb2D.velocity = new Vector2(horizontalInput * movementSpeed * Time.fixedDeltaTime, rb2D.velocity.y);      
    }

    private void OnMovement(InputValue axis) 
    {
        if (isGrounded)
            horizontalInput = axis.Get<float>();
    }

    private void OnJump()
    {
        if (isGrounded)
            rb2D.velocity += Vector2.up * jumpForce;
    }

    private void CheckForGround()
    {
        isGrounded = Physics2D.BoxCast(transform.position, groundCheckDimensions, 0f,
                     -transform.up, 0.1f, platformLayer);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireCube(transform.position, (Vector3)groundCheckDimensions);
    }
}
