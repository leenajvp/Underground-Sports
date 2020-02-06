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
        //if player collision with obstacle - 1 life, bull stops for 1-2 second?
        // if lives == 0 game over
    }
    //Meter? Player use rush bull, if meter reach red bulls will stop, game over
    //Timer if time run out, Game over

    //WINNING CONDITIONS
    //gold given only if no obstacles being hit and tail bit at least once? so as an example winning status gold if time = < 59 sec.
    //Silver if time = > 60 sec but smaller than 120 sec
    //Bronce is time > 120 sec
    // competitors could be informed as villages and random number generator such as 55-65 could be highest and 95-105 could be second.

}
