using UnityEngine;
using UnityEngine.Events;

public class PlayerFootstepAudio : MonoBehaviour
{
    public float walkThreshold = 1f;
    public UnityEvent onStartWalking, onStopWalking;

    private Jumper jumper;
    private Rigidbody2D rb2D;
    private bool isWalkingOnGround => jumper.isGrounded && Mathf.Abs(rb2D.velocity.x) > walkThreshold;
    private bool wasWalkingOnGroundLastFrame;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        jumper = GetComponent<Jumper>();
    }

    private void FixedUpdate()
    {
        if (isWalkingOnGround && !wasWalkingOnGroundLastFrame)
            onStartWalking?.Invoke();
        if(!isWalkingOnGround && wasWalkingOnGroundLastFrame)
            onStopWalking?.Invoke();


        wasWalkingOnGroundLastFrame = isWalkingOnGround;
    }
}
