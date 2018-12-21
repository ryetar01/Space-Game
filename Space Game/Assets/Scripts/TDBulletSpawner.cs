using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDBulletSpawner : MonoBehaviour
{
    public GameObject TheBullet;
    public Transform BulletSpawnPos;

    private void Update()
    {
        if (Input.GetKeyUp("e"))
        {
            Object.Instantiate(TheBullet, BulletSpawnPos);
            if (TheBullet.transform.rotation.eulerAngles.z == 0)
                {
                TheBullet.transform.localScale = new Vector3(1, 1, 1);
            }
            if (TheBullet.transform.rotation.eulerAngles.z == 180)
                {
                TheBullet.transform.localScale = new Vector3(-1, 1, 1);
            }
        }
    }

}
