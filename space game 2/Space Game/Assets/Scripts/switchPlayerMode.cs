using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class switchPlayerMode : MonoBehaviour {

    private GameObject player;
    public float xTelePos;
    public float yTelePos;
    private CanvasGroup screenDarkness;


    //public bool teleportPlayer;
    //public Vector2 teleportPos;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        screenDarkness = GameObject.Find("blackScreen").GetComponent<CanvasGroup>();

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
                return;
            }

            if (player.GetComponent<topdownMovement>() != null)
            {
                player.GetComponent<Rigidbody2D>().gravityScale = 1;
                Destroy(player.GetComponent<topdownMovement>());
                player.AddComponent<platformerMovement>();
                return;
            }
        }

        if (collision.gameObject.name == "Player")
        {
            player.transform.position = new Vector2(xTelePos, yTelePos);
            StartCoroutine(blackOut());

        }

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
