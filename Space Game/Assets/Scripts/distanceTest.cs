using UnityEngine;
using System;
using System.Collections;

public class distanceTest : MonoBehaviour
{
    [SerializeField]
    private float range = 10.0f;

    private Transform t;
    private Transform player;

    private void Awake()
    {
        t = this.transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (player)
            Debug.Log(player.name + " is " + Distance().ToString() + " units from " + t.name);

        else
            Debug.Log("Player not found!");
    }

    private float Distance()
    {
        return Vector3.Distance(t.position, player.position);
    }
}
