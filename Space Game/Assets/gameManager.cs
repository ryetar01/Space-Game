using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public bool gamemode;
    public Planeshift Shift1;
    public Planeshift Shift2;
    public bool Mainactive = true;
    //Used to tell which character is active.
    public int activeOther = 0;
    //0 is Cat, 1 is Chad, 2 is Mole, 3 is Owl.
    public GameObject player1;
    public GameObject player2;
     
    
    void Start()
    {
        gamemode = true;
        player1 = GameObject.FindGameObjectWithTag("Player");
        player2 = GameObject.FindGameObjectWithTag("InactivePlayer"); 
        //False is Platformer, Topdown is True.
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyUp("z"))
        {

        }
    }

    public void SpawnPlatformer()
    {
        
    }

    public void SpawnTopdown()
    {
        
    }
}
