using UnityEngine;
using UnityEngine.InputSystem;

public class Move1D : MonoBehaviour
{
    public float acceleration;
    public float maxSpeed;

    private float lastMove;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext obj)
    {
        lastMove = obj.ReadValue<float>();
    }

    private void FixedUpdate()
    {
        if (rb.velocity.sqrMagnitude < maxSpeed)
            rb.AddForce(new Vector2(lastMove * acceleration, 0));
    }
}
