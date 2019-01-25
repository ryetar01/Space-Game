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


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("topdownPlayer");
        trigCount = 0;
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
