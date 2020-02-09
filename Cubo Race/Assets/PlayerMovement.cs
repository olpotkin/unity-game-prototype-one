using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce  = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        //rb.useGravity = false;
        //rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    // Use FixedUpdate whenever use physics / forces updates
    void FixedUpdate()
    {
        // The higher is framerate the lower Time.deltaTime will be
        // Add a force on the z-axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Check user presses "Right" command button
        if (Input.GetKey("d"))
        {
            // Add force on x-axis
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        // Check user presses "Left" command button
        if (Input.GetKey("a"))
        {
            // Add force on x-axis
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
