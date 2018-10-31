using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardBullets : MonoBehaviour {

    public GameObject theBullet;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update ()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
        
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {

        StartCoroutine(End());
    }
    IEnumerator End()
    {
        //code to play animation
        yield return new WaitForSeconds(0.1f); //duration of animation
        Destroy(this.gameObject);
    }
   
}
