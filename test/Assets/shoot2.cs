using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot2 : MonoBehaviour {

    public Rigidbody bullet;

    void Fire()
    {
        
        transform.Translate(-1, 0, 0);
    }
	
    void back()
    {
        transform.Translate(1, 0, 0);
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire2"))
            Fire();

        if (Input.GetButton("Fire1"))
            back(); 
	}
}
