using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardBullets : MonoBehaviour {

    public GameObject theBullet;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private GameObject player2;
    private GameObject player;
    public float bulletSpeed;


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
        transform.Translate(Vector3.right * Time.deltaTime * bulletSpeed);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject != player || col.gameObject != player2)
        {
            StartCoroutine(End());
        }
    }

    IEnumerator End()
    {
        animator.SetBool("MCBulletanimswap",true);
        yield return new WaitForSeconds(0.2f); //duration of animation
        Destroy(this.gameObject);
    }
   
}
