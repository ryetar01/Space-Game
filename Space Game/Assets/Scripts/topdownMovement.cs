using UnityEngine;
using System.Collections;

public class topdownMovement : MonoBehaviour { 

    private Sprite faceView;
    private Sprite sideView;
    private Sprite backView;
    public bool isW;
    public bool isS;
    public bool isA;
    public bool isD;
    public float playerSpeed; //speed player moves 
    public Transform controlledplayer;
    public Transform otherplayer;
    public GameObject player1;
    public GameObject player2;
    public Vector2 offset;
    public float Dist;
    public float CorrectionTimer = 1.0f;
    private float time = 0.0f;
    public float MinorDistx;
    public float MinorDisty;
    

    void Start()
    {
        faceView = Resources.Load<Sprite>("Sprites/Front_Placeholder");
        sideView = Resources.Load<Sprite>("Sprites/Side_Back_Placeholder");
        backView = Resources.Load<Sprite>("Sprites/Side_Back_Placeholder");
        player1 = GameObject.FindGameObjectWithTag("Player");
        player2 = GameObject.FindGameObjectWithTag("InactivePlayer");
        controlledplayer = player1.transform;
        otherplayer = player2.transform;

    }

    private void Awake()
    {
        Countdown();
    }

    void Update()
    {
        MoveForward(); // Player Movement
        time += Time.deltaTime;
        

        if (time >= CorrectionTimer)
        {
            CorrectionTimer = 0;
            Correction();
        }

        offset = controlledplayer.position - otherplayer.position;

        Dist = Vector3.SqrMagnitude(controlledplayer.position - otherplayer.position);
        MinorDistx = otherplayer.position.x - controlledplayer.position.x;
        MinorDisty = otherplayer.position.y - controlledplayer.position.y;
        
        if (Dist >= 1.32)
        {
            player2.GetComponent<topdownMovement>().playerSpeed = 3;
        }
        else
        {
            player2.GetComponent<topdownMovement>().playerSpeed = 2f;
        }
    }

    public IEnumerator Countdown()
    {
        while (true)
        {
            CorrectionTimer--;
            yield return new WaitForSeconds(1);
        }
    }

    public void MoveForward()
    {

        if (GetComponent<TDInputHandler>().s == true)//Press up arrow key to move back on the Y AXIS
        {
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            GetComponent<SpriteRenderer>().sprite = faceView;
            isS = true;
            isW = false;
            isA = false;
            isD = false;
        }
        if (GetComponent<TDInputHandler>().d == true)//Press up arrow key to move forward on the X AXIS
        {
            //transform.rotation = Quaternion.Euler(0, 0, 90);
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
            transform.localScale = new Vector3(3.5f, 3.5f, 1);
            GetComponent<SpriteRenderer>().sprite = sideView;
            isD = true;
            isW = false;
            isA = false;
            isS = false;
        }
        if (GetComponent<TDInputHandler>().w == true)//Press up arrow key to move forward on the Y AXIS
        {
            //transform.rotation = Quaternion.Euler(0, 0, 180);
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
            GetComponent<SpriteRenderer>().sprite = backView;
            isW = true;
            isD = false;
            isA = false;
            isS = false;
        }
        if (GetComponent<TDInputHandler>().a == true)//Press up arrow key to move back on the X AXIS
        {
            //transform.rotation = Quaternion.Euler(0, 0, 270);
            transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
            GetComponent<SpriteRenderer>().sprite = sideView;
            transform.localScale = new Vector3(-3.5f, 3.5f, 1);
            isA = true;
            isD = false;
            isW = false;
            isS = false;
        }

    }
    public void Correction()
    {
        

        return;
        if (MinorDistx >= -0.5 && MinorDistx < 0)
        {
            /*while (otherplayer.position.x != controlledplayer.position.x)
            {
                if (MinorDistx < 0)
                {
                    player2.transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
                }
                if (MinorDistx > 0)
                {
                    player2.transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
                }
            } */
            player2.transform.Translate(-playerSpeed * Time.deltaTime / 3, 0, 0);
        }

        if (MinorDistx <= 0.5 && MinorDistx > 0)
        {
            player2.transform.Translate(playerSpeed * Time.deltaTime / 3, 0, 0);
        }

        if (MinorDisty >= -0.5 && MinorDistx > 0)
        {
            player2.transform.Translate(0, playerSpeed * Time.deltaTime / 3, 0);
            /* while (otherplayer.position.y != controlledplayer.position.y)
             {
                 if (MinorDisty < 0)
                 {
                     player2.transform.Translate(0, playerSpeed * Time.deltaTime, 0);
                 }
                 if (MinorDisty > 0)
                 {
                     player2.transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
                 }
             } */
        }

        if (MinorDisty <= 0.5 && MinorDistx < 0)
        {
            player2.transform.Translate(0, -playerSpeed * Time.deltaTime / 3, 0);
        }
    }
}
