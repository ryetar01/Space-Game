using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public float jump;
    public float speed;

    private Rigidbody rb;
	// Use this for initialization
	void Start () {
   
	}

    // Update is called once per frame
    void Update() {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 15.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 15.0f;

        transform.Translate(x, 0, 0);
        transform.Translate(0, 0, z);



    }
}
