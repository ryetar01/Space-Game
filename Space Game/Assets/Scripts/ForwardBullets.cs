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
    public bool bulletGo;
    public bool vorejazz;


    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        player2 = GameObject.Find("Player2");
        player = GameObject.Find("Player");
        vorejazz = true;
    }


    void Update ()
    {
        if (Input.GetKey("e") && vorejazz)
        {
            bulletGo = true;
            vorejazz = false;
        }

        if(bulletGo == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * bulletSpeed);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "!Player")
        {
            StartCoroutine(End());
        }
    }

    IEnumerator End()
    {
        bulletGo = false;
        animator.SetBool("MCBulletanimswap",true);
        yield return new WaitForSeconds(0.1f); //duration of animation
        Destroy(this.gameObject);
        vorejazz = true;
    }
   
}
