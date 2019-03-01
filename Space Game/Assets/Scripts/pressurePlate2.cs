using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate2 : MonoBehaviour
{
    public GameObject plate1;
    public GameObject plate2;
    public bool plate2on;
    public bool bothPressed;
    public Sprite plateUp;
    public Sprite plateDown;
    private GameObject player;
    private int trigCount;
    public GameObject bullet;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("topdownPlayer");
        trigCount = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if(plate1.GetComponent<PressurePlate1>().plate1on && plate2on)
        {
            bothPressed = true;
            GameObject.Find("Door").GetComponent<Animator>().SetTrigger("BothPressed");
            Destroy(GameObject.Find("Door").GetComponent<BoxCollider2D>());
            GameObject.Find("Door").GetComponent<SpriteRenderer>().sortingOrder = 900;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Physics2D.IgnoreCollision(other, bullet.GetComponent<Collider2D>());
        trigCount++;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        plate2on = true;
        GetComponent<SpriteRenderer>().sprite = plate2.GetComponent<PressurePlate2>().plateDown;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        plate2on = false;
        trigCount--;
        if(trigCount == 0)
        {
            GetComponent<SpriteRenderer>().sprite = plateUp;
        }
    }

}
