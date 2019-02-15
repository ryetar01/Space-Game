using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public bool gamemode;
    public Planeshift Shift1;
    public Planeshift Shift2;
    public bool mainActive;
    public bool catOn, catActive;
    public bool owlOn, owlActive;
    public bool moleOn, moleActive;
    public bool chadOn, chadActive;
     
    
    void Start()
    {
        gamemode = true;
        //False is Platformer, Topdown is True.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlatformer()
    {
        
    }

    public void SpawnTopdown()
    {
        
    }
}
