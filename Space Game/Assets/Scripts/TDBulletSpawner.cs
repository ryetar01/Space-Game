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
        }
    }

}
