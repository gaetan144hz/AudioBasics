using UnityEngine;
using UnityEngine.InputSystem;

public class Jumper : MonoBehaviour
{
    public float jumpForce;
    public LayerMask groundMask;

    private Rigidbody2D rb;
    private bool isGrounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnJump(InputAction.CallbackContext obj)
    {
        if (obj.performed)
            Jump();
    }

    private void Jump()
    {
        if (isGrounded)
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void Update()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f, groundMask);
    }
}
