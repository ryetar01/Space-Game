using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkAnim2D : MonoBehaviour {

    private GameObject player;
    public Animator playerAnimator;
    public bool isDPressed = false;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        playerAnimator = player.GetComponent<Animator>();
        playerAnimator.SetBool("ifMoving", false);
    }

    // Update is called once per frame
    void Update () {
        if (player.GetComponent<platformerMovement>().isA || player.GetComponent<platformerMovement>().isA == true){
            playerAnimator.SetBool("ifMoving", true);
        }

        while (Input.GetKeyDown("d"))
        {
            isDPressed = true;
        }

    }
}
