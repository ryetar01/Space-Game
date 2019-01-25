using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    private GameObject healthBar;
    private GameObject player;
    private Rigidbody2D playerRigidbody;
    public int flinchForce;
    public bool isFlinching = false;
    public int enemyDamage;


    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
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
        float oldDrag = playerRigidbody.drag;
        playerRigidbody.drag = 0.9f;
        isFlinching = true;
        yield return new WaitForSeconds(0.175f);
        playerRigidbody.drag = oldDrag;
        playerRigidbody.velocity = Vector2.zero;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            if (player.GetComponent<handleInput>().invincTimer == false)
            {
                healthBar.GetComponent<Health>().GotHit(enemyDamage);
                player.GetComponent<handleInput>().invincTimer = true;
            }

            //checking for if the player is using platformer
            if (player.GetComponent<platformerMovement>() != null)
            {
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
                //checking player direction
                if (player.GetComponent<topdownMovement>().isW)
                {
                    StartCoroutine(flinch(0, -flinchForce));
                }
                if (player.GetComponent<topdownMovement>().isS)
                {
                    StartCoroutine(flinch(0, flinchForce));
                }
                if (player.GetComponent<topdownMovement>().isA)
                {
                    StartCoroutine(flinch(flinchForce, 0));
                }
                if (player.GetComponent<topdownMovement>().isD)
                {
                    StartCoroutine(flinch(-flinchForce, 0));
                }
            }
        }
    }
}
