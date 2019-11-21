using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// The Goal detects that when the ball touches the goal, you win the level.
/// </summary>
public class Goal : MonoBehaviour
{
    public GameObject winText;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched trigger");
        if (collision.tag == "Player" )
        {
            winText.SetActive(true);
            /// Que sound effect here
            audioSource.Play();
            Debug.Log("The player has entered the goal!");
        }
    }
}
