using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchPlayerMode : MonoBehaviour {

    public GameObject player;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (player.GetComponent<platformerMovement>() != null)
        {
            player.GetComponent<Rigidbody2D>().gravityScale = 0;
            Destroy(player.GetComponent<platformerMovement>());
            player.AddComponent<topdownMovement>();
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Debug.Log("Worked Again?");
            return;
        }

        if (player.GetComponent<topdownMovement>() != null)
        {
            player.GetComponent<Rigidbody2D>().gravityScale = 1;
            Destroy(player.GetComponent<topdownMovement>());
            player.AddComponent<platformerMovement>();
            Debug.Log("Worked?");
            return;
        }
    }
}
