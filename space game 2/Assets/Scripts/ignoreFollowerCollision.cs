using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreFollowerCollision : MonoBehaviour {

    private GameObject player2;
    private GameObject player;

	// Use this for initialization
	void Start () {
		player2 = GameObject.Find("Player2");
        player = GameObject.Find("Player");
        StartCoroutine(matchTransform());
    }

    // Update is called once per frame
    void Update () {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (collision.gameObject == player2)
        {
            Physics2D.IgnoreCollision(player2.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }

    IEnumerator matchTransform()
    {
        yield return new WaitForSeconds(0.1f);
        player.transform.position = player2.transform.position;
    }

}
