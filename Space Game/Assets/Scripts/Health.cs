using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour {

    public Slider myHealthBar;

	// Use this for initialization
	void Start () {
        myHealthBar.value = 100;
	}

    // Update is called once per frame
    void Update()
    {
        if(myHealthBar.value == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
   

    public void GotHit(int damage)   {
        myHealthBar.value -= damage;
    }


}
