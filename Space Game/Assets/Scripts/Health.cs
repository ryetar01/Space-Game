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
        screenDarkness = GameObject.Find("blackScreen").GetComponent<CanvasGroup>();
        StartCoroutine(FadeIn());
    }

    // Update is called once per frame
    void Update()
    {
        if(myHealthBar.value == 0)
        {
            StartCoroutine(Death());
        }

    }
   

    public void GotHit(int damage)   {
        myHealthBar.value -= damage;
    }

    IEnumerator Death()
    {
        while (screenDarkness.alpha < 1)
        {
            screenDarkness.alpha += Time.deltaTime;
            yield return null;
        }
        StartCoroutine(FadeIn());
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    IEnumerator FadeIn()
    {
       screenDarkness.alpha = 1;
        while (screenDarkness.alpha > 0)
        {                   
            screenDarkness.alpha -= Time.deltaTime;  
            yield return null;
        }
    }

}
