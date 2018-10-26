using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class switchPlayerMode : MonoBehaviour {

    private GameObject player;
    private CanvasGroup screenDarkness;
    public Animator playerAnimator;
    public string sceneName;



    //public bool teleportPlayer;
    //public Vector2 teleportPos;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        screenDarkness = GameObject.Find("blackScreen").GetComponent<CanvasGroup>();
        playerAnimator = player.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            if (player.GetComponent<platformerMovement>() != null)
            {
                player.GetComponent<Rigidbody2D>().gravityScale = 0;
                Destroy(player.GetComponent<platformerMovement>());
                player.AddComponent<topdownMovement>();
                player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                playerAnimator.SetLayerWeight(0, 0);
                playerAnimator.SetLayerWeight(1, 1);
                loadLevel(sceneName);
                // StartCoroutine(blackOut()); 
                return;
            }

            if (player.GetComponent<topdownMovement>() != null)
            {
                player.GetComponent<Rigidbody2D>().gravityScale = 1;
                Destroy(player.GetComponent<topdownMovement>());
                playerAnimator.SetLayerWeight(0, 1);
                playerAnimator.SetLayerWeight(1, 0);
                player.AddComponent<platformerMovement>();
                player.transform.rotation = Quaternion.Euler(0, 0, 0);
                loadLevel(sceneName);
                //StartCoroutine(blackOut());
                return;
            }
        }

       

    }

    public void loadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }


    IEnumerator blackOut()
    {
        while (screenDarkness.alpha < 1)
        {
            screenDarkness.alpha += Time.deltaTime * 0.1f;
            Time.timeScale = 0.25f;
            yield return null;
        }
        StartCoroutine(blackIn());
    }


    IEnumerator blackIn()
    {
        Time.timeScale = 1;
        screenDarkness.alpha = 1;
        while (screenDarkness.alpha > 0)
        {
            screenDarkness.alpha -= Time.deltaTime;
            yield return null;
        }
    }

}
