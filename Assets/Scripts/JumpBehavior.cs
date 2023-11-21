using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpBehavior : MonoBehaviour
{
    public InputActionReference jumpActionRef = null;
    public Rigidbody body = null;
    public float jumpPower = 250.0f;
    public GroundCheck groundCheck = null;

    private void OnEnable()
    {
        jumpActionRef.action.performed += OnJumpInputPressed;
    }
    private void OnDisable()
    {
        jumpActionRef.action.performed -= OnJumpInputPressed;
    }

    private void OnJumpInputPressed(InputAction.CallbackContext context)
    {
        if (groundCheck.isGrounded) {
            Jump();
        }   
    }

    private void Jump()
    {
        body.AddForce(Vector3.up * jumpPower);
    }
}
