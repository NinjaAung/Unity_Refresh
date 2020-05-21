using UnityEngine;

public class player_collistions : MonoBehaviour
{
    public player_mov movement;
    // Player Collision
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if ( collisionInfo.collider.tag == "Obstacle" ) {
            movement.enabled = false;
        }

    }
}
