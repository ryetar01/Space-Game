﻿using System.Collections;
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
    public void Shoot()
    {
        Debug.Log("spawn worked");
        Instantiate(TheBullet, BulletSpawnPos);
        if (player.GetComponent<topdownMovement>().isA || player.GetComponent<topdownMovement>().isS)
        {
            TheBullet.transform.localScale = new Vector3(-1, 1, 1);
        }
        if (player.GetComponent<topdownMovement>().isD || player.GetComponent<topdownMovement>().isW)
        {
            TheBullet.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}