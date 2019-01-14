using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate1 : MonoBehaviour
{
    public GameObject plate1;
    public GameObject plate2;
    public bool plate1on;
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("topdownPlayer");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == GameObject.Find("TDMainCharacterBullet(Clone)"))
        {
            return;
        }
        plate1on = true;
        GetComponent<SpriteRenderer>().sprite = plate2.GetComponent<pressurePlate2>().plateDown;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        plate1on = false;
        GetComponent<SpriteRenderer>().sprite = plate2.GetComponent<pressurePlate2>().plateUp;
    }
}
