using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // A reference to the rigidbody component called "rb"
    public Rigidbody rb;

    // Variables
    public float forwardForce = 2000f; // Variable that determines the forward force
    public float sidewaysForce = 500f; // Variable that determines the sideways force

    // Update is called once per frame
    // Using .deltaTime makes it average once per second
    // Using FixedUpdate because we use it for physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //deltaTime makes this add force every 1 second. deltaTime is the amount of seconds since the computer drew the last frame

        if (Input.GetKey("d")) // If the player is pressing the "d" key
        {
            // Add a force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) // If the player is pressing the "a" key
        {
            // Add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EngGame();
        }
    }
}