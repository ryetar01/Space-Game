using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDBulletSpawner : MonoBehaviour
{
    private GameObject player;
    public GameObject TheBullet;
    public Transform BulletSpawnPos;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (Input.GetKeyUp("e"))
        {
            if (player.GetComponent<TDInputHandler>().isCanShoot)
            {
                Object.Instantiate(TheBullet, BulletSpawnPos);
                if (player.GetComponent<topdownMovement>().isA || player.GetComponent<topdownMovement>().isS)
                {
                    TheBullet.transform.localScale = new Vector3(-1, 1, 1);
                }
                if (player.GetComponent<topdownMovement>().isD || player.GetComponent<topdownMovement>().isW)
                {
                    TheBullet.transform.localScale = new Vector3(1, 1, 1);
                }
            }


            /*if (TheBullet.transform.rotation.eulerAngles.z == 0)
                {
                TheBullet.transform.localScale = new Vector3(1, 1, 1);
            }*/
            /*if (TheBullet.transform.rotation.eulerAngles.z == 180)
            {
                TheBullet.transform.localScale = new Vector3(-1, 1, 1);
            }*/
        }
    }

}