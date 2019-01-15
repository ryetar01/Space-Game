using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDForwardBullet : MonoBehaviour {

    public GameObject theBullet;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    public GameObject player2;
    public GameObject player;
    public float bulletSpeed;
    public bool bulletGo;
    public bool vorejazz;
    public bool shotEnemy;


    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        //player2 = GameObject.Find("Player");
        vorejazz = true;
        bulletGo = true;
    }


    void Update()
    {
        this.transform.parent = null;

        if (Input.GetKey("e") && vorejazz)
        {

            vorejazz = false;
        }

        if (bulletGo == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * bulletSpeed);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject != player || col.gameObject != player2)
        {
            if (col.gameObject.CompareTag("Enemy"))
            {
                //change this when enemy health becomes a thing
                Destroy(col.gameObject);
            }
            StartCoroutine(End());
        }

        if(col.gameObject == GameObject.FindWithTag("Enemy")){
            shotEnemy = true;
            Debug.Log("shot rat");
        }
    }

    IEnumerator End()
    {
        bulletGo = false;
        animator.SetBool("MCBulletanimswap", true);
        yield return new WaitForSeconds(0.1f); //duration of animation
        Destroy(this.gameObject);
        vorejazz = true;
    }

}
