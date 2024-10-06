using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;  // Horizontal movement speed
    public float jumpVelocity = 5f;  // Jump velocity
    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Get horizontal input (A/D or Left/Right arrow keys)
        float moveInput = Input.GetAxis("Horizontal");

        // Set the velocity in the X direction based on input and speed
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    void Update()
    {
        // Jump when spacebar is pressed (without force, using velocity)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Directly modify the Y velocity to make the object jump
            rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
        }
    }
}
