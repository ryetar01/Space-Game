using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderGateController : MonoBehaviour {

    private SpriteRenderer spriteRenderer;
    public Animator animator;

    void Awake () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
     }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        StartCoroutine(End());
    }
    IEnumerator End()
    {
        animator.SetInteger("GateHealth", value: 1);
        yield return new WaitForSeconds(0.2f); //duration of animation
    }

}
