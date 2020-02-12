using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        // It is more efficient to check the object by tag (not by its name)
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("We hit an obstacle!");

            // Stop the movement
            movement.enabled = false;
        }
    }
}
