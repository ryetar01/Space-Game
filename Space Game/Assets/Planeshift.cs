using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeshift : MonoBehaviour
{
    public GameObject gmobject;
    public GameObject player;
    public gameManager GM;
    
    public Vector2 Ppoint;
    public Vector2 Tpoint;
    public GameObject TDCamera;
    public GameObject PCamera;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gmobject = GameObject.Find("GameManager");
        GM = gmobject.GetComponent<gameManager>();
    }

    public void Scanplayers()
    {
        player = GameObject.FindWithTag("Player");    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GM.gamemode == true)
        {
            Object.Destroy(collision.gameObject);
            GM.SpawnTopdown();
        }
        else
        {
            Object.Destroy(collision.gameObject);
            GM.SpawnPlatformer();
        }
    }


}
