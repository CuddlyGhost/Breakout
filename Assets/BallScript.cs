using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(velocity, velocity);
    }

    private void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (rb.linearVelocityX < 0) 
        {
            rb.linearVelocityX = -velocity;
        }
        else
        {
            rb.linearVelocityX = velocity;
        }

        if (rb.linearVelocityY < 0)
        {
            rb.linearVelocityY = -velocity;
        }
        else
        {
            rb.linearVelocityY = velocity;
        }
            Debug.Log("Bounce!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
