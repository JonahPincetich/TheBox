using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This references the RigidBody component of the object
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    private bool moveRight = false;
    private bool moveLeft = false;


    // Update functions are called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            moveRight = true;
        }
        if (Input.GetKey("a"))
        {
            moveLeft = true;
        }
    }

    // FixedUpdate is used instead of Update when dealing with physics
    void FixedUpdate()
    {
        //Time.deltaTime is the last time the computer drew a frame
        //(Bring uniform across all machines runnning at all framerates)

        //Adds a force of forwardForce (z-axis)
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        //Add right and left forces on button clicks
        if (moveRight)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
            moveRight = false;
        }
        if (moveLeft)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
            moveLeft = false;
        }


        //Detect falling off map
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

    }
}
