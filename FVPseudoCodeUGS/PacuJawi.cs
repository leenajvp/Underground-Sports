using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour
{
    //Rigidbody2D rb;
    //public float moveSpeed;
        
    void Start()
    {
        //Start position, count 1,2,3 and move on set speed
        //Timer
    }

    // Update is called once per frame
    void Update()
    {
        //Move speed
        //Controller W = Up, S = Down, Space = Bite
        
    }
    //if space key down bite tail = speed * 2, reload 5 seconds
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if collision.tag.obstacle game over or lose life?
    }
    //Meter? Player use rush bull, if meter reach red bulls will stop, game over
    //Timer if time run out, Game over
}
