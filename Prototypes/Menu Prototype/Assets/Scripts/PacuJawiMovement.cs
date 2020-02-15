using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacuJawiMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float HorizontalMoveSpeed = 5f;
    public float VerticalMoveSpeed = 0.1f;
    private Rigidbody2D rb;
    Vector2 direction = new Vector2(10f, 0f);
    public bool activateMovement = true;

    private void Awake()
    {
        activateMovement = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //transform.position += Vector3.right * HorizontalMoveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.UpArrow))
       {
            transform.position += Vector3.up * VerticalMoveSpeed;
       }

       if (Input.GetKey(KeyCode.DownArrow))
       {
            transform.position += Vector3.down * VerticalMoveSpeed;
       }
    }

    void FixedUpdate()
    {
        if (activateMovement == true)
        {
            Movement();
        }
    }
    void Movement()
    {
        Vector2 movement = (direction).normalized * HorizontalMoveSpeed;
        rb.AddForce(movement);
    }

    IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.tag == ("Obstacle"))
            {
            activateMovement = false;
            yield return new WaitForSeconds(3);
            activateMovement = true;
            }
    }
    //When reach goal stop
}