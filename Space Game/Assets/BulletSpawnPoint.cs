using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnPoint : MonoBehaviour {

    public Vector3 offset;
    public Space player;
    public GameObject parent;
    public handleInput hi;

	void Start () {
        this.transform.localPosition = offset;
        parent = transform.parent.gameObject;
	}


    private void FixedUpdate()
    {

        if (hi.s == true)//Press up arrow key to move back on the Y AXIS
        {
            transform.RotateAround(new Vector3(0, 0, 1), 90f);

        }
        if (hi.d == true)//Press up arrow key to move forward on the X AXIS
        {
            transform.Rotate(0, 0, 0, Space.World);

        }
        if (hi.w == true)//Press up arrow key to move forward on the Y AXIS
        {
            transform.Rotate(0, 0, -90f, Space.World);

        }
        if (hi.a == true)//Press up arrow key to move back on the X AXIS
        {
            transform.Rotate(0, 0, 180f, Space.World);
        }
    }
}
