﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startmenu : MonoBehaviour
{
    public Camera Camera1; 
    public Camera Camera2;
    
    // Start is called before the first frame update
    void Start()
    {
        Camera1.enabled = true;
        Camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
      

        
    }
    public void SwitchCameras()
    {
        Camera1.enabled = false;
        Camera2.enabled = true;

        //put all the code to switch cameras here
    }
}
