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

        if (Input.GetKeyDown(KeyCode.A))
        
            transform.rotation = Quaternion.Euler(0, -180, 0);
     
        

        if (Input.GetKeyDown(KeyCode.D))
        
            transform.rotation = Quaternion.Euler(0, 0, 0);
        
   
       
    }

}


