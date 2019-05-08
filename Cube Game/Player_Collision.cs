
using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    public Player_movement movement;
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }



}
