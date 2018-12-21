using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnPoint : MonoBehaviour
{
    
    public Vector3 offsetright;
    public GameObject parent;
    public TDInputHandler hi;
    public Vector3 offsetup;
    public Vector3 offsetdown;
    public Vector3 offsetleft;


    void Start()
    {
        //this.transform.localPosition = offsetright;
        parent = transform.parent.gameObject;
    }


    private void FixedUpdate()
    {

        if (hi.s == true)//Press up arrow key to move back on the Y AXIS
        {
            transform.SetPositionAndRotation(parent.transform.position + offsetdown, Quaternion.Euler(new Vector3(0, 0, -90)));

        }
        if (hi.d == true)//Press up arrow key to move forward on the X AXIS
        {
           
            transform.SetPositionAndRotation(parent.transform.position + offsetright, Quaternion.Euler(new Vector3(0, 0, 0)));

        }
        if (hi.w == true)//Press up arrow key to move forward on the Y AXIS
        {
            transform.SetPositionAndRotation(parent.transform.position + offsetup, Quaternion.Euler(new Vector3(0, 0, 90)));

        }
        if (hi.a == true)//Press up arrow key to move back on the X AXIS
        {
            
            transform.SetPositionAndRotation(parent.transform.position + offsetleft, Quaternion.Euler(new Vector3(0, 0, 180)));

        }
    }
}
