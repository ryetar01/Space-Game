using UnityEngine;
using System.Collections;

public class topdownMovement : MonoBehaviour
{
    private Sprite faceView;
    private Sprite sideView;
    private Sprite backView;
    public bool isW;
    public bool isS;
    public bool isA;
    public bool isD;



    //Inspector Variables
    private float playerSpeed = 3; //speed player moves 

    private void Start()
    {
        faceView = Resources.Load<Sprite>("Sprites/Front_Placeholder");
        sideView = Resources.Load<Sprite>("Sprites/Side_Back_Placeholder");
        backView = Resources.Load<Sprite>("Sprites/Side_Back_Placeholder");


    }
    void Update()
    {
        moveForward(); // Player Movement
    }

    private void moveForward()
    {

        if (GetComponent<handleInput>().s == true)//Press up arrow key to move back on the Y AXIS
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            //playerSpriteRenderer.sprite = new Sprite(faceView);
            GetComponent<SpriteRenderer>().sprite = faceView;
            isS = true;
            isW = false;
            isA = false;
            isD = false;
        }
        if (GetComponent<handleInput>().d == true)//Press up arrow key to move forward on the X AXIS
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            GetComponent<SpriteRenderer>().sprite = sideView;
            isD = true;
            isW = false;
            isA = false;
            isS = false;
        }
        if (GetComponent<handleInput>().w == true)//Press up arrow key to move forward on the Y AXIS
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            GetComponent<SpriteRenderer>().sprite = backView;
            isW = true;
            isD = false;
            isA = false;
            isS = false;
        }
        if (GetComponent<handleInput>().a == true)//Press up arrow key to move back on the X AXIS
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            GetComponent<SpriteRenderer>().sprite = sideView;
            isA = true;
            isD = false;
            isW = false;
            isS = false;
        }

    }
}
