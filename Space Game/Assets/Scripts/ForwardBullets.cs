﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardBullets : MonoBehaviour {

    public GameObject theBullet;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    public GameObject player2;
    public GameObject player;
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
        player = GameObject.FindWithTag("Player");
        //player2 = GameObject.Find("Player");
        vorejazz = true;
        bulletGo = true;
    }

    public void Scanplayers()
    {
        player = GameObject.FindWithTag("Player");
    }


    void Update ()
    {
        this.transform.parent = null;

        if (Input.GetKey("e") && vorejazz)
        {
            
            vorejazz = false;
        }

        if(bulletGo == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * bulletSpeed);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject != player && col.gameObject != player2)
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
