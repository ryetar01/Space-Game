using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour {

    public GameObject healthBar;

	// Use this for initialization
	void Start () {	
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            healthBar.GetComponent<health>().gotHit();
        }
    }
}
