using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour {

    public Slider myHealthBar;
    private CanvasGroup screenDarkness;

	// Use this for initialization
	void Start () {
        myHealthBar.value = 100;
        //screenDarkness = GameObject.Find("blackScreen");
        FadeIn();
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

    public void FadeIn()
    {
       // blackScreen.GetComponent<CanvasGroup>().alpha = 1;

    }

}
