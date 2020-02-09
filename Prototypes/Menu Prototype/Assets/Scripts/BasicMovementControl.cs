using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovementControl : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(0, 0);
    }

    // Update is called once per frame
    //Basic movement
    void Update()
    {
        CalculateMovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 10f;
            rb.velocity = Vector2.up * jumpVelocity;
        }
    }
    void CalculateMovement()
    { 
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.right * horizontalInput * Speed * Time.deltaTime);
    }
    
}

