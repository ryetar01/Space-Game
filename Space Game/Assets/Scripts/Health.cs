﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour {

    public Slider myHealthBar;

	// Use this for initialization
	void Start () {
        myHealthBar.value = 100;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

            myHealthBar.value += 1;

        }







        if (Input.GetKeyDown(KeyCode.S))
        {
            myHealthBar.value -= 1;
        }
    }
}
