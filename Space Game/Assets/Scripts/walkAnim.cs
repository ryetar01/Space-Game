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
    }
}
