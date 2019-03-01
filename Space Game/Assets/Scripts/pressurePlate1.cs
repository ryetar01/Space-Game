using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate1 : MonoBehaviour
{
    public GameObject plate1;
    public GameObject plate2;
    public bool plate1on;
    private GameObject player;
    private int trigCount;
    public GameObject bullet;



    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());
        player = GameObject.Find("topdownPlayer");
        trigCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == bullet)
        {
            Physics2D.IgnoreCollision(bullet.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        trigCount++;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        plate1on = true;
        GetComponent<SpriteRenderer>().sprite = plate2.GetComponent<PressurePlate2>().plateDown;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        plate1on = false;
        trigCount--;
        if(trigCount == 0)
        {
            GetComponent<SpriteRenderer>().sprite = plate2.GetComponent<PressurePlate2>().plateUp;
        }
    }
}
