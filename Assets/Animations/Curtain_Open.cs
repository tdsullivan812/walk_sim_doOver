using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curtain_Open : MonoBehaviour
{
    Animator animator;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position[2] >= 660)
        {
            animator.SetTrigger("Open");
        }
    }
}
