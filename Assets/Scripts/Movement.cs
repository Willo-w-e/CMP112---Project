using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class NewMonoBehaviourScript : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed = 5f;
    public float jumpspeed = 10f;
    int jumptotal = 0;
    int maxjumps = 2;

    public Transform groundCheck;
    public Vector2 groundCheckSize = new Vector2(0.5f, 0.5f);
    public LayerMask groundLayer;


    float horizontalMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
    }


    void Update()
    {
        rb.linearVelocity = new Vector2(horizontalMovement * speed, rb.linearVelocity.y);

        if (rb.linearVelocity.y == 0.0f)
        {
            jumptotal = 0;
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontalMovement = context.ReadValue<Vector2>().x;
    }


    public void Jump(InputAction.CallbackContext context)
    {
        if(context.performed && jumptotal < maxjumps)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpspeed);
            jumptotal++;
        }
        else if (context.canceled)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }
    }
}