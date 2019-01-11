using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate2 : MonoBehaviour
{
    public GameObject plate1;
    public GameObject plate2;
    public bool plate2on;
    public bool bothPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(plate1.GetComponent<pressurePlate1>().plate1on && plate2on)
        {
            bothPressed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        plate2on = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        plate2on = false;
    }

}
