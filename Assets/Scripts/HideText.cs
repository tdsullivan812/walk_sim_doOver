using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideText : MonoBehaviour
{
    Vector3 origin;
    float dotproduct;
    Vector3 normal;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        origin = this.transform.position;
        normal = this.transform.forward;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (normal[0]*(player.transform.position[0]-origin[0]) + normal[1]*(player.transform.position[1]-origin[1]) +normal[2]*(player.transform.position[2]-origin[2]) > 0)
        {
            GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
