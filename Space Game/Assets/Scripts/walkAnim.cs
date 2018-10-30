using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkAnim : MonoBehaviour {

    private GameObject player;
    public Animator playerAnimator;
    public bool isWPressed = false;
    public bool isSPressed = false;
    public bool isAPressed = false;
    public bool isDPressed = false;



    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        playerAnimator = player.GetComponent<Animator>();
        playerAnimator.SetBool("ifPlatformerMoving", false);
        playerAnimator.SetBool("ifTopdownMoving", false);
        Debug.Log("Platformer: " + playerAnimator.GetLayerIndex("Platformer Layer"));
        Debug.Log("Topdown: " + playerAnimator.GetLayerIndex("Topdown Layer"));
        playerAnimator.SetLayerWeight(0, 1);
        playerAnimator.SetLayerWeight(1, 0);

    }

    // Update is called once per frame
    void Update () {

        //tracks while the key is pressed unlike the key tracking with flinch, will be useful for other scripts
        if (Input.GetKey("w"))
        {
            isWPressed = true;
        }
        if (Input.GetKeyUp("w"))
        {
            isWPressed = false;
        }
        if (Input.GetKey("s"))
        {
            isSPressed = true;
        }
        if (Input.GetKeyUp("s"))
        {
            isSPressed = false;
        }
        if (Input.GetKey("a"))
        {
            isAPressed = true;
        }
        if (Input.GetKeyUp("a"))
        {
            isAPressed = false;
        }
        if (Input.GetKey("d"))
        {
            isDPressed = true;
        }
        if (Input.GetKeyUp("d"))
        {
            isDPressed = false;
        }

        //checks if platformer
        if(playerAnimator.GetLayerWeight(0) == 1)
        {
            if (isAPressed || isDPressed)
            {
                playerAnimator.SetBool("ifPlatformerMoving", true);
            }
            else
            {
                playerAnimator.SetBool("ifPlatformerMoving", false);
            }
        }

        //checks if topdown
        if (playerAnimator.GetLayerWeight(1) == 1)
        {
            if (isWPressed || isSPressed || isAPressed || isDPressed)
            {
                playerAnimator.SetBool("ifTopdownMoving", true);
            }
            else
            {
                playerAnimator.SetBool("ifTopdownMoving", false);
            }
        }




    }
}
