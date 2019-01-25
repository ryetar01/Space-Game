using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigassrattopdown : MonoBehaviour {

    private Transform t;
    private Transform player;
    private bool hit;
    public float enemySpeed;
    public bool hitEnemy;
    public float distanceToPlayer;
    private bool assRatAttack;
    // Use this for initialization


    private void Awake()
    {
        t = this.transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Start () {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        hit = true;
    }


    // Update is called once per frame
    void Update () {
        distanceToPlayer = float.Parse(Distance().ToString());
        if(distanceToPlayer <= 10)
        {
            assRatAttack = true;
        }
        if(assRatAttack == true)
        {
            transform.parent.Translate(Vector3.up * Time.deltaTime * enemySpeed);
        }

       if (hit == true)
        {
            transform.parent.Rotate(0, 0, Random.Range(90, 270));
            hit = false;
        }
    }

    private float Distance()
    {
        return Vector3.Distance(t.position, player.position);
    }


}
