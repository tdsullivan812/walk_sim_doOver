using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class branches_recede : MonoBehaviour
{
    GameObject player;
    GameObject branch;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        branch = GameObject.Find("branches");
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter()
    {
        branch.GetComponent<Animator>().SetTrigger("approach");
    }
}
