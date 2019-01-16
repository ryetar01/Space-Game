using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigassrattopdown : MonoBehaviour {
    private bool hit;
    public float enemySpeed;
    public bool hitEnemy;
	// Use this for initialization
	void Start () {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        hit = true;
    }


    // Update is called once per frame
    void Update () {
        transform.parent.Translate(Vector3.up * Time.deltaTime * enemySpeed);

       if (hit == true)
        {
            transform.parent.Rotate(0, 0, Random.Range(90, 270));
            hit = false;
        }
    }


}
