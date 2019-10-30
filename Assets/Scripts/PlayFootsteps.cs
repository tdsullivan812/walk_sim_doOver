using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFootsteps : MonoBehaviour
{
    AudioSource footsteps;
    int counter;
    // Start is called before the first frame update
    void Start()
    {
        footsteps = GetComponentInChildren<AudioSource>();
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            if (counter <= 0)
            {
                counter = 45;
                footsteps.Play();
            }
        }
        counter--;
    }

}