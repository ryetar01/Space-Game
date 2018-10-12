using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReloadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        ReloadLevel();
	}

    void ReloadLevel()
}
    if(Input.GetKey (KeyCode.R))
    {
        Application.LoadLevel (Application.LoadedLevel);
    {
   