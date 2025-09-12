using UnityEngine;

public class WASD2 : MonoBehaviour

{

    public float speed = 10f;
    public Rigidbody2D myRB;
    public bool jumped = false;
    public bool grounded = false;
    public float jumpForce = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && grounded)
        {
            jumped = true;
        }

    }

    void FixedUpdate()
    {
        Vector3 velocity = Vector3.zero;

        /* if (Input.GetKey(KeyCode.W))
         {
             velocity.y = speed;
         }
         if (Input.GetKey(KeyCode.S))
         {
             velocity.y = -speed;
         } */
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x = speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = -speed;
        }
        myRB.AddForce(velocity);

        if (jumped)
        {
            Jump();
            jumped = false;
        }

    }


    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Collided with: " + collision.gameObject);
        grounded = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Stopped Colliding with: " + collision.gameObject);
        grounded = false;
    }

    void Jump()
    {
        myRB.AddForce(Vector3.up * jumpForce);
    }


}

