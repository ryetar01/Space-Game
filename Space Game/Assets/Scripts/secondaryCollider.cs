using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondaryCollider : MonoBehaviour {

    public GameObject theBullet;
    private GameObject player2;
    private GameObject player;
    public bool hitWall;

    // Use this for initialization
    void Start () {
        player2 = GameObject.Find("Player2");
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collider2D col)
    {
        if (col.gameObject != player || col.gameObject != player2 || col.gameObject != theBullet)
        {
            hitWall = true;
        }
    }
}
