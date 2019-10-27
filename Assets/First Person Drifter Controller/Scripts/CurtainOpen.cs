using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainOpen : MonoBehaviour
{

    public bool curtOpen;
    public GameObject curtains;
    // Start is called before the first frame update
    void Start()
    {
        curtOpen = false;
        curtains = GameObject.Find("stage_curtains_1297");
    }

    // Update is called once per frame
    void Update()
    {
        if ((this.transform.position[2] >= 0) && curtOpen == false)
        {
            curtOpen = true;
            curtains.GetComponent<Animation>().Play();
        }
    }
}
