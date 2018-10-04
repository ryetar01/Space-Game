using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformerCamera : MonoBehaviour {

    private Vector3 playerXYcameraZ;
    private GameObject player;
    public float playerDistanceFromCameraX;
    public float playerDistanceFromCameraY;
    public int yOffset;
    public int xOffset;
    public float panSpeed;
    public int cameraTransitionOffsetX;
    public int cameraTransitionOffsetY;
    public bool correctMode = false;
    public bool correctMode2 = false;


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
            playerDistanceFromCameraX = player.transform.position.x - transform.position.x + cameraTransitionOffsetX;
            playerDistanceFromCameraY = player.transform.position.y - transform.position.y + cameraTransitionOffsetY;

            if (correctMode)
            {
                frozenPlayerTransform = player.transform.position;
                playerXYcameraZ = new Vector3(frozenPlayerTransform.x + cameraTransitionOffsetX, frozenPlayerTransform.y + cameraTransitionOffsetY, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, playerXYcameraZ, 0.1f);
                if (Mathf.Abs(playerDistanceFromCameraX) < 0.2f)
                {
                    correctMode = false;
                }

            } else if  (playerDistanceFromCameraX > 8 || playerDistanceFromCameraX < -5)
            {
                correctMode = true;
            }

            if (correctMode2)
            {
                frozenPlayerTransform = player.transform.position;
                playerXYcameraZ = new Vector3(frozenPlayerTransform.x + cameraTransitionOffsetX, frozenPlayerTransform.y + cameraTransitionOffsetY, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, playerXYcameraZ, 0.05f);
                if (Mathf.Abs(playerDistanceFromCameraY) < 0.2f)
                {
                    correctMode2 = false;
                }

            }
            else if (playerDistanceFromCameraY > 4 || playerDistanceFromCameraY < -1)
            {
                correctMode2 = true;
            }


        }


		
	}
}


