﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class health : MonoBehaviour {

    public Slider myHealthBar;

	// Use this for initialization
	void Start () {
        myHealthBar.value = 100;
	}

    // Update is called once per frame
    void Update()
    {
        if (myHealthBar.value <= 0)
        {
            Debug.Log("character dead lol, dab XD");
        }
    }

    public void gotHit()
    {
        myHealthBar.value -= 30;
    }


}
