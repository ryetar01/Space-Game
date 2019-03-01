using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdirection : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.E))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }

        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.E))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
   
       
    }

}


