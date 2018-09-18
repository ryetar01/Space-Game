using UnityEngine;
using System.Collections;

public class topdownMovement : MonoBehaviour
{
    public Sprite faceView;
    public Sprite sideView;
    public Sprite backView;

    //Inspector Variables
    public int playerSpeed = 10; //speed player moves 
    void Update()
    {
        moveForward(); // Player Movement
    }

    private void moveForward()
    {

        if (Input.GetKey("s"))//Press up arrow key to move back on the Y AXIS
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            //playerSpriteRenderer.sprite = new Sprite(faceView);
            GetComponent<SpriteRenderer>().sprite = faceView;
        }
        if (Input.GetKey("d"))//Press up arrow key to move forward on the X AXIS
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            GetComponent<SpriteRenderer>().sprite = sideView;
        }
        if (Input.GetKey("w"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            GetComponent<SpriteRenderer>().sprite = backView;
        }
        if (Input.GetKey("a"))//Press up arrow key to move back on the X AXIS
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            GetComponent<SpriteRenderer>().sprite = sideView;
        }

    }
}
