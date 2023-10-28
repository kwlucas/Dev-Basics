using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool groundedPlayer;
    private bool jumping = false;
    private Vector2 movement;
    public float playerSpeed = 2.0f;
    public float jumpHeight = 1.0f;
    public float jumpCooldown = 0.5f;
    private float jumpTime = 0.0f;
    // public float gravityValue = -9.81f;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();


    }
    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);

        // If it hits something...
        if (hit.collider != null)
        {
            groundedPlayer = true;
        }
        else
        {
            groundedPlayer = false;
        }
        if (Input.GetButton("Jump") && groundedPlayer && !jumping)
        {
            jumping = true;
            jumpTime = jumpCooldown;
            movement.x = 0;
            movement.y = jumpHeight;
            body.AddForce(movement, ForceMode2D.Impulse);
        }
        if (jumpTime > 0.0f)
        {
            jumpTime -= Time.deltaTime;
        }
        else if (groundedPlayer)
        {
            jumping = false;

        }
        movement.y = 0;

        movement.x = Input.GetAxis("Horizontal") * playerSpeed;
        body.AddForce(movement * Time.deltaTime);

    }
}
