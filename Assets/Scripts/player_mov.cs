using UnityEngine;

public class player_mov : MonoBehaviour
{
    public Rigidbody rb;
    public float forward_force = 0.0f;
    public float side_force = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    // Fixed Update is prefered for calculating physics
    void FixedUpdate() 
    {   
        if ( Input.GetKey(KeyCode.W) )
        {
            rb.AddForce(0,0, forward_force * Time.deltaTime);
        }
        if ( Input.GetKey(KeyCode.S) )
        {
            rb.AddForce(0,0, -forward_force * Time.deltaTime);
        }
        if ( Input.GetKey(KeyCode.D) )
        {
            rb.AddForce(side_force * Time.deltaTime, 0, 0);
        }
        if ( Input.GetKey(KeyCode.A) )
        {
            rb.AddForce(-side_force * Time.deltaTime, 0, 0);
        }

    }
}
