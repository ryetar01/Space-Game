using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {

	// Use this for initialization
	void Reset () {
        Application.LoadLevel(Application.loadedLevel);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R)) 
        Reset();
	}
}
