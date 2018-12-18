using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topdownCamera : MonoBehaviour {

    private GameObject player;
    private GameObject player2;


    // Use this for initialization
    void Start () {
        player = GameObject.Find("topdownPlayer");
        player2 = GameObject.Find("Player2");

    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<TDInputHandler>().playingPlayer1 == true)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        }

        if (player.GetComponent<TDInputHandler>().playingPlayer1 == false)
        {
            transform.position = new Vector3(player2.transform.position.x, player2.transform.position.y, -10);
        }
    }
}
