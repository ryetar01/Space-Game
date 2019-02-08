using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class platformerMovement : MonoBehaviour
{
    public GameObject player;
    public GameObject player2;
    private LayerMask groundLayer;
    private Rigidbody2D myRigidbody;
    private float jumpForce = 15f;
    private float playerSpeed = 5f;
    private Sprite sideView;
    public bool isD;
    public bool isA;
   

    private void Start()
    {
       // sideView = Resources.Load<Sprite>("Resources/Sprites/new piskel (2)_0");
        groundLayer = LayerMask.GetMask("Ground");
        myRigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        player2 = GameObject.Find("Player2");
        

    }


    //Inspector Variables
    //speed player moves 
    void Update()
    {
        moveForward(); // Player Movement
    }
    

    private void moveForward()
    {

        if (GetComponent<handleInput>().d == true)//Press up arrow key to move forward on the X AXIS
        {
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
            //GetComponent<SpriteRenderer>().sprite = sideView;
            isD = true;
            isA = false;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (GetComponent<handleInput>().a == true)//Press up arrow key to move backward on the X AXIS
        {
            transform.Translate(-playerSpeed * Time.deltaTime,0, 0);
            //GetComponent<SpriteRenderer>().sprite = sideView;
            isA = true;
            isD = false;
            GetComponent<SpriteRenderer>().flipX = true;

        }


        if (GetComponent<handleInput>().space == true)
        {
            //Made two different raycast pos so the 2nd player doesnt detect the ground based on the first player
            //yes it had to be formatted this way, some reason it wouldn't work otherwise
            if (GetComponent<handleInput>().mainPlayer)
            {
                //All 3 player raycasts positions (WILL NEED TO BE ADJUSTED! probably)
                Vector2 position = new Vector2(player.transform.position.x, player.transform.position.y);
                Vector2 position2 = new Vector2(player.transform.position.x - 0.325f, player.transform.position.y);
                Vector2 position3 = new Vector2(player.transform.position.x + 0.325f, player.transform.position.y);
                Vector2 direction = Vector2.down;
                float distance = 1;  //THIS WILL NEED TO BE ADJUSTED WITH A NEW CHARACTER MODEL!
                RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
                RaycastHit2D hit2 = Physics2D.Raycast(position2, direction, distance, groundLayer);
                RaycastHit2D hit3 = Physics2D.Raycast(position3, direction, distance, groundLayer);
                Debug.DrawRay(position3, direction, Color.green, groundLayer);
                Debug.DrawRay(position2, direction, Color.green, groundLayer);
                Debug.DrawRay(position, direction, Color.green, groundLayer);

                if (hit.collider != null || hit2.collider != null || hit3.collider != null)
                {
                    myRigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                    GetComponent<handleInput>().space = false;
                }
            }
            else
            {
                //All 3 player raycasts positions (WILL NEED TO BE ADJUSTED! probably)
                Vector2 position = new Vector2(player2.transform.position.x, player2.transform.position.y);
                Vector2 position2 = new Vector2(player2.transform.position.x - 0.325f, player2.transform.position.y);
                Vector2 position3 = new Vector2(player2.transform.position.x + 0.325f, player2.transform.position.y);

                Vector2 direction = Vector2.down;
                float distance = 1;  //THIS WILL NEED TO BE ADJUSTED WITH A NEW CHARACTER MODEL!
                RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
                RaycastHit2D hit2 = Physics2D.Raycast(position2, direction, distance, groundLayer);
                RaycastHit2D hit3 = Physics2D.Raycast(position3, direction, distance, groundLayer);
                Debug.DrawRay(position3, direction, Color.green, groundLayer);
                Debug.DrawRay(position2, direction, Color.green, groundLayer);
                Debug.DrawRay(position, direction, Color.green, groundLayer);

                if (hit.collider != null || hit2.collider != null || hit3.collider != null)
                {
                    myRigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                    GetComponent<handleInput>().space = false;
                }
            }

        }

    }

}
