using UnityEngine;
using System.Collections;

public class platformerMovement : MonoBehaviour
{
    private GameObject player;
    private LayerMask groundLayer;
    private Rigidbody2D myRigidbody;
    private float jumpForce = 5f;
    private float playerSpeed = 3f;
    private Sprite sideView;
    public bool isD;
    public bool isA;


    private void Start()
    {
        sideView = Resources.Load<Sprite>("Sprites/Side_Back_Placeholder");
        groundLayer = LayerMask.GetMask("Ground");
        myRigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    private bool isGrounded()
    {
        //All 3 player raycasts positions (WILL NEED TO BE ADJUSTED! probably)
        Vector2 position = transform.position;
        Vector2 position2 = new Vector2(transform.position.x - 0.5f, transform.position.y);
        Vector2 position3 = new Vector2(transform.position.x + 0.5f, transform.position.y);


        Vector2 direction = Vector2.down;
        float distance = 0.4f;  //THIS WILL NEED TO BE ADJUSTED WITH A NEW CHARACTER MODEL!
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        RaycastHit2D hit2 = Physics2D.Raycast(position2, direction, distance, groundLayer);
        RaycastHit2D hit3 = Physics2D.Raycast(position3, direction, distance, groundLayer);

        //Checking to see if any come up on ground and if so can jump
        if (hit.collider != null || hit2.collider != null || hit3.collider != null)
        {
            return true;
        }

        return false;
    }


    //Inspector Variables
    //speed player moves 
    void Update()
    {
        moveForward(); // Player Movement
    }

    private void moveForward()
    {

        if (Input.GetKey("d"))//Press up arrow key to move forward on the X AXIS
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            GetComponent<SpriteRenderer>().sprite = sideView;
            isD = true;
            isA = false;
        }
        if (Input.GetKey("a"))//Press up arrow key to move backward on the X AXIS
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            GetComponent<SpriteRenderer>().sprite = sideView;
            isA = true;
            isD = false;
        }


        if (Input.GetKeyDown("space"))
        {
           if (isGrounded())
            {
                myRigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

            }

        }

    }
}
