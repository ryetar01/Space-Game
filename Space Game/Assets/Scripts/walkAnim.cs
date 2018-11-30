using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkAnim : MonoBehaviour {
    public Animator playerAnimator;
    // Use this for initialization
    void Start () {
        playerAnimator = GetComponent<Animator>();

        //the bool that determines whether the player uses the platformer animation layer
        playerAnimator.SetBool("ifPlatformerMoving", false);

        //checks what the script needs to identify the layers as
        Debug.Log("Platformer: " + playerAnimator.GetLayerIndex("Platformer Layer"));
        Debug.Log("Topdown: " + playerAnimator.GetLayerIndex("Topdown Layer"));

    }

    // Update is called once per frame
    void Update () {

        //checks if platformer
        if(GetComponent<platformerMovement>())
        {
            playerAnimator.SetLayerWeight(0, 1);
            playerAnimator.SetLayerWeight(1, 0);
            if (GetComponent<handleInput>().a == true || GetComponent<handleInput>().d == true)
            {
                playerAnimator.SetBool("ifPlatformerMoving", true);
            }
            else
            {
                playerAnimator.SetBool("ifPlatformerMoving", false);
            }
        }
        else
        {
            playerAnimator.SetLayerWeight(0, 0);
            playerAnimator.SetLayerWeight(1, 1);
        }

        //checks if topdown
        if (GetComponent<topdownMovement>())
        {
            if (GetComponent<handleInput>().w == true)
            {
                playerAnimator.SetBool("ifTopdownRunW", true);
            }
            else
            {
                playerAnimator.SetBool("ifTopdownRunW", false);
            }
            if (GetComponent<handleInput>().a == true)
            {
                playerAnimator.SetBool("ifTopdownRunAD", true);
            }
            else if(GetComponent<handleInput>().a == false && GetComponent<handleInput>().d == false)
            {
                playerAnimator.SetBool("ifTopdownRunAD", false);
            }
            if (GetComponent<handleInput>().d == true)
            {
                playerAnimator.SetBool("ifTopdownRunAD", true);
            }
            else if (GetComponent<handleInput>().a == false && GetComponent<handleInput>().d == false)
            {
                playerAnimator.SetBool("ifTopdownRunAD", false);
            }
            if (GetComponent<handleInput>().s == true)
            {
                playerAnimator.SetBool("ifTopdownRunS", true);
            }
            else
            {
                playerAnimator.SetBool("ifTopdownRunS", false);
            }
        }




    }
}
