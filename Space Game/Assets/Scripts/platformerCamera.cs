using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformerCamera : MonoBehaviour {

    /*what needs to be done: need to start tracking the player once a or d is pressed and once they move a certain
      amount until they stop in which the camera will stop and fin*/

    private Vector3 playerXYcameraZ;
    private GameObject player;
    public float playerDistanceFromCamera;
    public int yOffset;
    public int xOffset;
    public float panSpeed;
    public int cameraTransitionOffsetX;
    public int cameraTransitionOffsetY;
    public bool correctMode = false;

    //for the purpose of using the player transform once he activates the if statement
    private Vector3 frozenPlayerTransform;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        yOffset = 1;
        xOffset = -6;
        panSpeed = 1;
        cameraTransitionOffsetX = 3;
        cameraTransitionOffsetY = 1;
    }

    // Update is called once per frame

    void Update () {
       

        if(player.GetComponent<platformerMovement>().isA || player.GetComponent<platformerMovement>().isD)
        {
            playerDistanceFromCamera = player.transform.position.x - transform.position.x + cameraTransitionOffsetX;
            //Vector3 offset = player.transform.position.x - transform.position.x;

            if (correctMode)
            {
                frozenPlayerTransform = player.transform.position;
                playerXYcameraZ = new Vector3(frozenPlayerTransform.x + cameraTransitionOffsetX, frozenPlayerTransform.y + cameraTransitionOffsetY, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, playerXYcameraZ, 0.1f);
                if (Mathf.Abs(playerDistanceFromCamera) < 0.2f)
                {
                    correctMode = false;
                }

            } else if  (playerDistanceFromCamera > 8 || playerDistanceFromCamera < -5)
            {
                correctMode = true;
                //transform.position = new Vector3(player.transform.position.x - xOffset, transform.position.y /*yOffset*/, -10);

            }

        }


		
	}
}


