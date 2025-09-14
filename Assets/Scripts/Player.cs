using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public float moveSpeed = 5f; 

    private Rigidbody2D rb;
    private Vector2 movement;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component missing from this GameObject.");
        }
    }
    void Update()
    {  
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;
    }

    void FixedUpdate()
    { 
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}