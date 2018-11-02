using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class platformerMovement : MonoBehaviour
{
    public GameObject player;
    private LayerMask groundLayer;
    private Rigidbody2D myRigidbody;
    private float jumpForce = 15f;
    private float playerSpeed = 3f;
    private Sprite sideView;
    public bool isD;
    public bool isA;

    private void Start()
    {
       // sideView = Resources.Load<Sprite>("Resources/Sprites/new piskel (2)_0");
        groundLayer = LayerMask.GetMask("Ground");
        myRigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        
    }

    private bool isGrounded()
    {
        //All 3 player raycasts positions (WILL NEED TO BE ADJUSTED! probably)
        Vector2 position = transform.position;
        Vector2 position2 = new Vector2(transform.position.x - 0.35f, transform.position.y);
        Vector2 position3 = new Vector2(transform.position.x + 0.35f, transform.position.y);


        Vector2 direction = Vector2.down;
        float distance = 1.5f;  //THIS WILL NEED TO BE ADJUSTED WITH A NEW CHARACTER MODEL!
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        RaycastHit2D hit2 = Physics2D.Raycast(position2, direction, distance, groundLayer);
        RaycastHit2D hit3 = Physics2D.Raycast(position3, direction, distance, groundLayer);
        Debug.DrawRay(position3, direction, Color.green, groundLayer);

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
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
            //GetComponent<SpriteRenderer>().sprite = sideView;
            isD = true;
            isA = false;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey("a"))//Press up arrow key to move backward on the X AXIS
        {
            transform.Translate(-playerSpeed * Time.deltaTime,0, 0);
            //GetComponent<SpriteRenderer>().sprite = sideView;
            isA = true;
            isD = false;
            GetComponent<SpriteRenderer>().flipX = true;

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
