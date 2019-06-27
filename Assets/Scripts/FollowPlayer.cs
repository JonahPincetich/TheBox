using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Refernce to the player
    public Transform player;

    //The offset to place the camera back behind the player
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        //Change the position of the camera bassed on the player
        transform.position = player.position + offset;
    }
}
