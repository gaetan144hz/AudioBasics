using UnityEngine;
using UnityEngine.InputSystem;

public class Jumper : MonoBehaviour
{
    public float jumpForce;
    public LayerMask groundMask;
    public AudioSource source;

    private Rigidbody2D rb;
    public bool isGrounded { get; private set; }

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
        if (!isGrounded)
            return;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        if(source!= null)
            source.Play();
    }

    private void Update()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f, groundMask);
    }
}
