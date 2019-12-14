using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fail : MonoBehaviour
{
    public GameObject loseText;

    private AudioSource audiosource;

    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched Trigger");
        if (collision.tag == "Player")
        {
            loseText.SetActive(true);
            /// Que sound effect here
            audiosource.Play();
            Debug.Log("The player has lost");
        }

    }
}
