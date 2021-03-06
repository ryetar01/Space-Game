﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class switchPlayerMode : MonoBehaviour {

    private GameObject player;
    public Animator playerAnimator;
    private GameObject mainCamera;
    public string scene;


    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        playerAnimator = player.GetComponent<Animator>();
        mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update () {

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            if (player.GetComponent<platformerMovement>() != null)
            {
                player.GetComponent<Rigidbody2D>().gravityScale = 0;
                Destroy(player.GetComponent<platformerMovement>());
                player.AddComponent<topdownMovement>();
                Destroy(mainCamera.GetComponent<platformerCamera>());
                mainCamera.AddComponent<topdownCamera>();
                player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                playerAnimator.SetLayerWeight(0, 0);
                playerAnimator.SetLayerWeight(1, 1);
                sceneChange();
                return;
            }

            if (player.GetComponent<topdownMovement>() != null)
            {
                player.GetComponent<Rigidbody2D>().gravityScale = 1;
                Destroy(player.GetComponent<topdownMovement>());
                playerAnimator.SetLayerWeight(0, 1);
                playerAnimator.SetLayerWeight(1, 0);
                player.AddComponent<platformerMovement>();
                Destroy(mainCamera.GetComponent<topdownCamera>());
                mainCamera.AddComponent<platformerCamera>();
                player.transform.rotation = Quaternion.Euler(0, 0, 0);
                sceneChange();
                return;
            }
        }
    }

    private void sceneChange()
    {
        SceneManager.LoadScene(scene);
    }
}
