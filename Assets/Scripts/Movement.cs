using UnityEngine;
using UnityEngine.InputSystem;


public class NewMonoBehaviourScript : MonoBehaviour
{

    private Rigidbody2D rb;
    public int speed = 10;
    public int jumpstrength = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Vector2 moveVector = new Vector2(moveHorizontal, moveVertical);

        //rb.AddForce(moveVector * speed);
    }


    public void OnMove()
    {
        float moveHorizontal = speed;

        Vector2 moveVector = new Vector2(moveHorizontal, 0.0f);

        rb.AddForce(moveVector);
    }


    public void OnJump(InputValue Value)
    {
        float moveVertical = jumpstrength;

        Vector2 jumpVector = new Vector2(0.0f, moveVertical);
        rb.AddForce(jumpVector, ForceMode2D.Impulse);
    }

}
