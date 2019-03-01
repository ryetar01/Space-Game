using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDirection2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            transform.rotation = Quaternion.Euler(0, 0, 270);
        
    }
}
