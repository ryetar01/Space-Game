using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public bool gamemode;
    public Planeshift Shift1;
    public bool Mainactive = true;
    //Used to tell which character is active.
    public int activeOther = 0;
    //0 is Cat, 1 is Chad, 2 is Mole, 3 is Owl.
    public GameObject player1;
    public GameObject player2;
    public GameObject platplayer1;
    public Vector2 Platpoint;
   // public TDForwardBullet TDFB;
    //public ForwardBullets FRB = ;
    public List<TDInputHandler> TDIH = new List<TDInputHandler>();
    public List<topdownMovement> TDM = new List<topdownMovement>();
    public GameObject TDCamera;
    public topdownCamera TDC;
    
    void Start()
    {
        player1 = GameObject.FindWithTag("Player");
        player2 = GameObject.FindWithTag("InactivePlayer");

        TDIH.Add(player1.GetComponent<TDInputHandler>());
        TDIH.Add(player2.GetComponent<TDInputHandler>());
        TDM.Add(player2.GetComponent<topdownMovement>());
        TDM.Add(player1.GetComponent<topdownMovement>());
        TDC = TDCamera.GetComponent<topdownCamera>();

        gamemode = true;
              
        //False is Platformer, Topdown is True.
    }

    public void Scanplayers()
    {
        player1 = GameObject.FindWithTag("Player");
        player2 = GameObject.FindWithTag("InactivePlayer");
    }

    // Update is called once per frame
    void Update()
    {
       if (player2 == GameObject.Find("TopdownChad"))
        {
            activeOther = 0;
        }
       if (player2 == GameObject.Find("TopdownOwl"))
        {
            activeOther = 1;
        }
       if (player2 == GameObject.Find("TopdownCat"))
        {
            activeOther = 2;
        }
       if (player2 == GameObject.Find("TopdownMole"))
        {
            activeOther = 3;
        }
       if (player2 == GameObject.Find("topdownPlayer"))
        {
            activeOther = 4;
        }

       if (Input.GetKeyDown(KeyCode.R))
        {
            player1.tag = "InactivePlayer";
            player2.tag = "Player";
            Scanplayers();
            //TDFB.Scanplayers();
            // FRB.Scanplayers();

            foreach (TDInputHandler td in TDIH)
            {
                td.Scanplayers();
            }
            
            foreach(topdownMovement tm in TDM)
            {
                tm.Scanplayers();
            }
            
            TDC.Scanplayers();
}
    }

    public void SpawnPlatformer()
    {
        
    }

    public void SpawnTopdown()
    {
        
    }
}
