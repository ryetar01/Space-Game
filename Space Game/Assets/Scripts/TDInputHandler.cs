using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDInputHandler : MonoBehaviour {

   
    public bool w;
    public bool s;
    public bool a;
    public bool d;
    public bool z;
    public float delay;
    private bool wInputUp;
    public bool mainPlayer;
    public bool invincTimer;
    public bool playingPlayer1;
    public GameObject player;
    public GameObject player2;
    public bool isCanShoot;



    // Use this for initialization
    void Start()
    {
        isCanShoot = true;
        playingPlayer1 = true;
        player = GameObject.FindGameObjectWithTag("topdownPlayer");
        player2 = GameObject.Find("topdownChad");
    }

    public void Scanplayers()
    {
        player = GameObject.FindWithTag("Player");
        player2 = GameObject.FindWithTag("InactivePlayer");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("f") && playingPlayer1 == true)
        {
            playingPlayer1 = false;
            player2.GetComponent<TDInputHandler>().delay = 0;
            player.GetComponent<TDInputHandler>().delay = 1;
        }
        else if (Input.GetKeyUp("f") && playingPlayer1 == false)
        {
            playingPlayer1 = true;
            player2.GetComponent<TDInputHandler>().delay = 1;
            player.GetComponent<TDInputHandler>().delay = 0;
        }
        if (invincTimer == true)
        {
            StartCoroutine(invincWait());
        }
        if (Input.GetKey("w"))
        {
            StartCoroutine(WPressed());
        }
        else if (Input.GetKeyUp("w"))
        {
            StartCoroutine(WUp());
        }
        if (Input.GetKey("s"))
        {
            StartCoroutine(SPressed());
        }
        else if (Input.GetKeyUp("s"))
        {
            StartCoroutine(SUp());
        }
        if (Input.GetKey("a"))
        {
            StartCoroutine(APressed());
        }
        else if (Input.GetKeyUp("a"))
        {
            StartCoroutine(AUp());
        }
        if (Input.GetKey("d"))
        {
            StartCoroutine(DPressed());
        }
        else if (Input.GetKeyUp("d"))
        {
            StartCoroutine(DUp());
        }
        if (Input.GetKey("e") && isCanShoot)
        {
            player.GetComponent<TDBulletSpawner>().Shoot();
            StartCoroutine(ShootTimer());
        }
        if (Input.GetKey("z"))
        {
            StartCoroutine(Teleport2p());
        }
    }


    IEnumerator ShootTimer()
    {
        isCanShoot = false;
        yield return new WaitForSeconds(0.3f);
        isCanShoot = true;
    }
    IEnumerator Teleport2p()
    {
        z = true;
        yield return new WaitForSeconds(0.3f);
        z = false;
    }

    IEnumerator WPressed()
    {
        yield return new WaitForSeconds(delay);
        w = true;
    }
    IEnumerator SPressed()
    {
        yield return new WaitForSeconds(delay);
        s = true;
        if (Input.GetKeyUp("s"))
        {
            s = false;
        }
    }
    IEnumerator APressed()
    {
        yield return new WaitForSeconds(delay);
        a = true;
        if (Input.GetKeyUp("a"))
        {
            a = false;
        }
    }
    IEnumerator DPressed()
    {
        yield return new WaitForSeconds(delay);
        d = true;
        if (Input.GetKeyUp("d"))
        {
            d = false;
        }
    }
    

    IEnumerator WUp()
    {
        yield return new WaitForSeconds(delay);
        w = false;
    }

    IEnumerator SUp()
    {
        yield return new WaitForSeconds(delay);
        s = false;
    }

    IEnumerator AUp()
    {
        yield return new WaitForSeconds(delay);
        a = false;
    }
    IEnumerator DUp()
    {
        yield return new WaitForSeconds(delay);
        d = false;
    }

    IEnumerator invincWait()
    {
        yield return new WaitForSeconds(1);
        invincTimer = false;
    }
}
