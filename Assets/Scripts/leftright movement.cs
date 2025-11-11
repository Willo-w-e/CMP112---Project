using UnityEngine;

public class LeftRightMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private SpriteRenderer spriteRenderer;
    public float moveSpeed = 5f;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        // Move the player
        body.linearVelocity = new Vector2(horizontalInput * moveSpeed, body.linearVelocity.y);

        // Flip sprite based on direction
        if (horizontalInput != 0)
            spriteRenderer.flipX = horizontalInput < 0f;
    }
}
