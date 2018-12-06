using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPatrol : MonoBehaviour {

    public float enemySpeed;
    private GameObject bigAssRatCollider;

    // Use this for initialization
    void Start () {
        bigAssRatCollider = GameObject.Find("Collider");
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.right * Time.deltaTime * enemySpeed);

        if (bigAssRatCollider.GetComponent<secondaryCollider>().hitWall ==  true)
        {
            Debug.Log("WEEEE");
        }
    }


}
