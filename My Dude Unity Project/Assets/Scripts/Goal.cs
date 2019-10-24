using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// The Goal detects that when the ball touches the goal, you win the level.
/// </summary>
public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched trigger");
        if (collision.tag == "Player" )
        {
            Debug.Log("The player has entered the goal!");
        }
    }
}
