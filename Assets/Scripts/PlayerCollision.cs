using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    //Function provided by unity that gets called on a collision
    //Requires object to have a rigid body and a collider
    private void OnCollisionEnter(Collision collisionInfo)
    {
        //collisionInfo holds information on the collision
        //EX: collisionInfo.collider is the other object in the collision
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //Disables movement
            movement.enabled = false;

            //Finds the Game Manager object being used in the current scene
            FindObjectOfType<GameManager>().GameOver();

        }
    }


}
