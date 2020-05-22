using UnityEngine;

public class player_mov : MonoBehaviour
{
    public Rigidbody rb;
    public float forward_force = 0.0f;
    public float side_force = 0.0f;

    private float current_speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        current_speed = 0.0f; 
        if ( Input.GetKey(KeyCode.D) )
        {
            current_speed = side_force;
        } 
        else if ( Input.GetKey(KeyCode.A) )
        {
            current_speed = -side_force;
        }

    }

    // Fixed Update is prefered for calculating physics
    void FixedUpdate() 
    {   
        rb.AddForce(0,0,forward_force * Time.deltaTime);
        rb.AddForce(current_speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
