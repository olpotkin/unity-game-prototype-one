using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

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
        // Add a force of 2000 on the z-axis
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
