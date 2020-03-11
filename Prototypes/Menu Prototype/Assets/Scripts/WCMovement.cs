using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WCMovement : MonoBehaviour
{
    public float Speed;
    public float SlowerSpeed;

    public GameObject Water;
    public GameObject Ground;

    public AnimationState idle;
    public bool GroundCheck = true;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(-4.18f, 2.63f);
    }

    // Update is called once per frame
    //Basic movement
    void Update()
    {
        CalculateMovement();

        if (Input.GetKeyDown(KeyCode.W) && GroundCheck == true)
        {
            float jumpVelocity = 10f;
            rb.velocity = Vector2.up * jumpVelocity;
        }
    }
    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        //AnimationState == run;

        transform.Translate(Vector2.right * horizontalInput * Speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Water)
        {
            Speed = 2;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Speed = 6;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Ground)
        {
            GroundCheck = true;
        }
        else
        {
            GroundCheck = false;
        }
    }
}
