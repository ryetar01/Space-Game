using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    private GameObject healthBar;
    private GameObject player;
    private Rigidbody2D playerRigidbody;
    public int flinchForce;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        playerRigidbody = player.GetComponent<Rigidbody2D>();
        healthBar = GameObject.Find("health");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator flinch(float a, float b)
    {
        playerRigidbody.AddForce(new Vector2(a, b), ForceMode2D.Impulse);
        yield return new WaitForSeconds(0.175f);
        Debug.Log("did pause");
        playerRigidbody.AddForce(new Vector2(-a, -b), ForceMode2D.Impulse);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            healthBar.GetComponent<health>().gotHit();

            //checking for if the player is using platformer
            if (player.GetComponent<platformerMovement>() != null)
            {
                Debug.Log("using platformer");
                //checking player direction
                if (player.GetComponent<platformerMovement>().isA == true)
                {
                    StartCoroutine(flinch(flinchForce, 0));
                }
                if (player.GetComponent<platformerMovement>().isD == true)
                {
                    StartCoroutine(flinch(-flinchForce, 0));
                }
            }

            //checking for if the player is using topdown
            if (player.GetComponent<topdownMovement>() != null)
            {
                Debug.Log("using topdown");
                //checking player direction
                if (player.GetComponent<topdownMovement>().isW)
                {
                    StartCoroutine(flinch(0, -flinchForce));
                }
                if (player.GetComponent<topdownMovement>().isS == true)
                {
                    StartCoroutine(flinch(0, flinchForce));
                }
                if (player.GetComponent<topdownMovement>().isA == true)
                {
                    StartCoroutine(flinch(flinchForce, 0));
                }
                if (player.GetComponent<topdownMovement>().isD == true)
                {
                    StartCoroutine(flinch(-flinchForce, 0));
                }
            }
        }
    }
}
