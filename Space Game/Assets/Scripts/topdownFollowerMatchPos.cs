using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topdownFollowerMatchPos : MonoBehaviour {

    private GameObject player;
    private GameObject player2;
    public float speed;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update () {
        float step = speed * Time.deltaTime;

        if (player.GetComponent<handleInput>().playingPlayer1)
        {
            if (Input.GetKeyUp("w") || Input.GetKeyUp("s") || Input.GetKeyUp("a") || Input.GetKeyUp("d"))
            {
                if (transform.position.x != player.transform.position.x && transform.position.y != player.transform.position.y)
                {
                    Debug.Log("XD");
                    transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
                }
            }
        }

        if (player.GetComponent<handleInput>().playingPlayer1 == false)
        {
            if (Input.GetKeyUp("w") || Input.GetKeyUp("s") || Input.GetKeyUp("a") || Input.GetKeyUp("d"))
            {
                if (player.transform.position.x != transform.position.x && player.transform.position.y != transform.position.y)
                {
                    Debug.Log("DX");
                    player.transform.position = Vector3.MoveTowards(player.transform.position, transform.position, step);
                }
            }
        }
    }
}
