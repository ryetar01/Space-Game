using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardBullets : MonoBehaviour {

    public GameObject theBullet;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private GameObject player2;
    private GameObject player;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        player2 = GameObject.Find("Player2");
        player = GameObject.Find("Player");
    }


    void Update ()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            return;
        }

        if (collision.gameObject == player2)
        {
            Physics2D.IgnoreCollision(player2.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            return;
        }
        StartCoroutine(End());
    }

    void spawnBullet()
    {
        var bullet = Instantiate(theBullet, transform.position, transform.rotation);
    }

   /* public void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(End());
    }*/
    IEnumerator End()
    {
        animator.SetBool("MCBulletanimswap",true);
        yield return new WaitForSeconds(0.2f); //duration of animation
        Destroy(this.gameObject);
    }
   
}
