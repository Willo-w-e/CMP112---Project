using JetBrains.Annotations;
using UnityEngine;

public class HoverPlatform : MonoBehaviour
{

    public float floatHeight;
    public float lift;

    public Rigidbody2D rb2d;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up);

        if (hit)
        {
            bool valid = hit.transform.CompareTag("Player");

            if (valid)
            {

                float distance = Mathf.Abs(hit.point.y - transform.position.y);
                float height = floatHeight - distance;


                float force = lift * height - rb2d.linearVelocity.y;

                rb2d.AddForce(Vector2.up * force);
            }
        }

    }
}



