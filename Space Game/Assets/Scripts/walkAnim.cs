using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkAnim : MonoBehaviour {
    public Animator playerAnimator;
    public Animator player2Animator;

    // Use this for initialization
    void Start () {
        playerAnimator = GetComponent<Animator>();
        playerAnimator.SetBool("ifPlatformerMoving", false);
        playerAnimator.SetBool("ifTopdownMoving", false);
        Debug.Log("Platformer: " + playerAnimator.GetLayerIndex("Platformer Layer"));
        Debug.Log("Topdown: " + playerAnimator.GetLayerIndex("Topdown Layer"));

    }

    // Update is called once per frame
    void Update () {
        if (GetComponent<platformerMovement>())
        {
            playerAnimator.SetLayerWeight(0, 1);
            playerAnimator.SetLayerWeight(1, 0);
        }
        else
        {
           playerAnimator.SetLayerWeight(0, 0);
            playerAnimator.SetLayerWeight(1, 1);
        }

        //checks if platformer
        if(playerAnimator.GetLayerWeight(0) == 1)
        {
            if (GetComponent<handleInput>().a == true || GetComponent<handleInput>().d == true)
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
            if (GetComponent<handleInput>().w == true || GetComponent<handleInput>().s == true || GetComponent<handleInput>().a == true || GetComponent<handleInput>().d == true)
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
