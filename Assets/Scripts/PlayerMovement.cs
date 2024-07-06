using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed;
    private Rigidbody2D rb;

    private PlayerStates playerStates;


    public void Initialize(float speed, PlayerStates playerStates)
    {
        this.playerStates = playerStates;

        moveSpeed = speed;
        rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(0, 0);

        direction direction = direction.down;

        if (Input.GetKey(KeyCode.A))
        {
            movement.x -= 1;
            direction = direction.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.x += 1;
            direction = direction.right;

        }
        if (Input.GetKey(KeyCode.W))
        {
            movement.y += 1;
            direction = direction.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement.y -= 1;
            direction = direction.down;
        }

        
        

        if (movement.magnitude > 0)
        {
            playerStates.direction = direction;
            playerStates.isWalking = true;
            rb.velocity = movement.normalized * moveSpeed * Mathf.Pow(rb.drag, 0.5f) * Time.deltaTime;
        } else {
            playerStates.isWalking = false;
        }
    }
}