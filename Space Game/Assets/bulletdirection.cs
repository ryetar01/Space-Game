﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdirection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
            transform.rotation = Quaternion.Euler(0, 180, 0);
        if (Input.GetKey("d"))
            transform.rotation = Quaternion.Euler(180, 0, 0);
    }

}


