using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopdownWalkAnim : MonoBehaviour {

    public Animator playerAnimator;
    // Use this for initialization
    void Start()
    {
        playerAnimator = GetComponent<Animator>();

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
    }

    // Update is called once per frame
    void Update() {
        if (GetComponent<TDInputHandler>().w == true)
        {
            playerAnimator.SetBool("ifTopdownRunW", true);
        }
        else
        {
            playerAnimator.SetBool("ifTopdownRunW", false);
        }
        if (GetComponent<TDInputHandler>().a == true)
        {
            playerAnimator.SetBool("ifTopdownRunAD", true);
        }
        else if (GetComponent<TDInputHandler>().a == false && GetComponent<TDInputHandler>().d == false)
        {
            playerAnimator.SetBool("ifTopdownRunAD", false);
        }
        if (GetComponent<TDInputHandler>().d == true)
        {
            playerAnimator.SetBool("ifTopdownRunAD", true);
        }
        else if (GetComponent<TDInputHandler>().a == false && GetComponent<TDInputHandler>().d == false)
        {
            playerAnimator.SetBool("ifTopdownRunAD", false);
        }
        if (GetComponent<TDInputHandler>().s == true)
        {
            playerAnimator.SetBool("ifTopdownRunS", true);
        }
        else
        {
            playerAnimator.SetBool("ifTopdownRunS", false);
        }
    }
}
