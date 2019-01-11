using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate1 : MonoBehaviour
{
    public GameObject plate1;
    public bool plate1on;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        plate1on = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        plate1on = false;
    }
}
