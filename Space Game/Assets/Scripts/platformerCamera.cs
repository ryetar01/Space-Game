﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformerCamera : MonoBehaviour {

    /*what needs to be done: need to start tracking the player once a or d is pressed and once they move a certain
      amount until they stop in which the camera will stop and fin*/

    private GameObject player;
    public float playerDistanceFromCamera;
    public int yOffset;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        yOffset = 1;
    }

    // Update is called once per frame

    void Update () {
       

        if(player.GetComponent<platformerMovement>().isA || player.GetComponent<platformerMovement>().isD)
        {
            playerDistanceFromCamera = player.transform.position.x - transform.position.x;
            //Vector3 offset = player.transform.position.x - transform.position.x;


            if (playerDistanceFromCamera > 8 || playerDistanceFromCamera < -8)
            {
                transform.position = new Vector3(player.transform.position.x, transform.position.y /*yOffset*/, -10);
                /*if(player.GetComponent<Rigidbody2D>().IsSleeping()) 
                {
                    
                }*/
            }

        }


		
	}
}


