using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handleInput : MonoBehaviour {

    public GameObject theBullet;
    public bool space;
    public bool w;
    public bool s;
    public bool a;
    public bool d;
    public float delay;
    private bool wInputUp;
    public bool isCanShoot;
    public bool mainPlayer;
    private Vector2 bulletSpawnPos;
    private Quaternion rotation;

    // Use this for initialization
    void Start () {
        isCanShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(spacePressed());
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
            if(mainPlayer == true)
            {
                if (GetComponent<platformerMovement>().isA)
                {
                    rotation = Quaternion.Euler(0, 0, 180);
                    bulletSpawnPos = new Vector2(transform.position.x - 1, transform.position.y);
                }
                else if(GetComponent<platformerMovement>().isD)
                {
                    rotation = Quaternion.Euler(0, 0, 0);
                    bulletSpawnPos = new Vector2(transform.position.x + 1, transform.position.y);
                }
                var bullet = Instantiate(theBullet, bulletSpawnPos, rotation);
                isCanShoot = false;
                StartCoroutine(shootTimer());
            }

        }
    }

    IEnumerator spacePressed()
    {
        yield return new WaitForSeconds(delay);
        space = true;
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
    IEnumerator shootTimer()
    {
        yield return new WaitForSeconds(0.3f);
        isCanShoot = true;
    }
}
