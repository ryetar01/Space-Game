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
        player = GameObject.Find("topdownPlayer");
    }
    private void Update()
    {
    }

    public void Shoot()
    {
        Debug.Log("shoot");
        Object.Instantiate(TheBullet, BulletSpawnPos);
        if (player.GetComponent<topdownMovement>().isA)
        {
            TheBullet.transform.localScale = new Vector3(-1, -1, -1);
        }
        if (player.GetComponent<topdownMovement>().isS)
        {
            TheBullet.transform.localScale = new Vector3(-1, -1, 1);
        }
        if (player.GetComponent<topdownMovement>().isD)
        {
            TheBullet.transform.localScale = new Vector3(1, 1, 1);
        }
        if (player.GetComponent<topdownMovement>().isW)
        {
            TheBullet.transform.localScale = new Vector3(1, 1, 1);
        }
    }

}