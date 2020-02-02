using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;
        
    void Start()
    {
        //Start position, count 1,2,3 and move
        // AI second character move on 3, speed set 0,5 slower.
    }

    // Update is called once per frame
    void Update()
    {
        //Move speed
        //Controller D = forward, A = Backward, W = Jump (Dry obstacle)
        
    }
    //WATER OBSTACLE
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If collision with water speed / 2
        //if (Input.GetKeyDown("Space"))
        //{
          //speed * 2
        // }
    }
}
