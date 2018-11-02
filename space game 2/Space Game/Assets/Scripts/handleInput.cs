using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handleInput : MonoBehaviour {

    //variables will be added here instead of to individual scripts
    public bool space;
    public bool w;
    public bool s;
    public bool a;
    public bool d;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("space"))
        {
            space = true;
        }

	}
}
