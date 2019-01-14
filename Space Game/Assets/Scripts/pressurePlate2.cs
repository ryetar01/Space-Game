using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate2 : MonoBehaviour
{
    public GameObject plate1;
    public GameObject plate2;
    public bool plate2on;
    public bool bothPressed;
    public Sprite plateUp;
    public Sprite plateDown;
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("topdownPlayer");

    }
    // Update is called once per frame
    void Update()
    {
        if(plate1.GetComponent<pressurePlate1>().plate1on && plate2on)
        {
            bothPressed = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == GameObject.Find("TDMainCharacterBullet(Clone)"))
        {
            Debug.Log("nani");
            return;
        }
        plate2on = true;
        GetComponent<SpriteRenderer>().sprite = plateDown;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        plate2on = false;
        GetComponent<SpriteRenderer>().sprite = plateUp;
    }

}
