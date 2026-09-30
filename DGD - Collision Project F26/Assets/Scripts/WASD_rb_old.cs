using UnityEngine;
using UnityEngine.InputSystem;

public class WASD_rb_old : MonoBehaviour
{
    //Variables
    public Rigidbody2D rb;
    public float forceamount = 3f;
  
    public GAMEMANAGER gw;
    private SpriteRenderer color;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //I want to script the rigidbody from my game object onto this script
        rb = GetComponent<Rigidbody2D>();

        //set the color to the sprite renderer
        color = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Make the square move up if I press W
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * forceamount);
        }

        //Make the square move down if I press S
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * forceamount);
        }

        //Make the square move left if I press A
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * forceamount);
        }

        //Make the square move right if I press D
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * forceamount);
        }



    }

    //On collision change the color of our square
    private void OnCollisionEnter2D(Collision2D collision)
   
        //sends a message to the console and randomly changes color each collision
    {
        Debug.Log("-1 aura");
        color.color = Random.ColorHSV();
    }

    //Desrtroy the collectible on trigger enter
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy whatever I run into
        Destroy(collision.gameObject);

        //Change color on collision
        color.color = Random.ColorHSV();

        //Respawn the collectible
        gw.Respawn();

    }

}