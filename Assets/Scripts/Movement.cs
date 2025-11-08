using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class NewMonoBehaviourScript : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed = 5f;
    public float jumpspeed = 10f;
    int jumptotal = 0;
    int maxjumps = 2;


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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Intro")
        {
            SceneManager.LoadScene(sceneName: "Level 1");
        }

        if (other.tag == "Level 1")
        {
            SceneManager.LoadScene(sceneName: "Level 2");
        }

        if (other.tag == "Level 2")
        {
            SceneManager.LoadScene(sceneName: "Level 3");
        }
    }
}