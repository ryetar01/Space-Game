using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class health : MonoBehaviour {

    public Slider myHealthBar;

	// Use this for initialization
	void Start () {
        myHealthBar.value = 100;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Scene thisScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(thisScene.name);
        }
    }

    public void gotHit()
    {
        myHealthBar.value -= 5;
    }


}
