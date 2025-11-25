using UnityEngine;

public class playerMoveMap : MonoBehaviour
{
    private Rigidbody2D rb;

    private float move_x = 0;
    private float move_y = 0;
    
    public float move_speed = 10;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float move_x = Input.GetAxisRaw("Horizontal");
        float move_y = Input.GetAxisRaw("Vertical");

        rb.linearVelocity = new Vector2(move_x * move_speed, rb.linearVelocityY);
        rb.linearVelocity = new Vector2(rb.linearVelocityX, move_y * move_speed);
    }
}
