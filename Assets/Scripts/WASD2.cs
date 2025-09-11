using UnityEngine;

public class WASD2 : MonoBehaviour

{

public float speed = 10f;
public Rigidbody myRB;   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Vector3 velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            velocity.y = speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity.y = speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.y = -speed;
        }
        myRB.linearVelocity = velocity;

    }
}
