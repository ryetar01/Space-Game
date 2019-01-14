using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigassrattopdown : MonoBehaviour {
    private bool rat;
    public float enemySpeed;
    private GameObject bigAssRatCollider;
    public bool hitEnemy;
	// Use this for initialization
	void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Time.deltaTime * enemySpeed);

       if (rat == true)
        {
            transform.Rotate(0, 0, Random.Range(90, 270));
            rat = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        rat = true;
    }
}
