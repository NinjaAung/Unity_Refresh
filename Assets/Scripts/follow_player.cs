using UnityEngine;

public class follow_player : MonoBehaviour
{
    public Transform player;
    // Vector3 is (X,Y,Z) Storing of a variable
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Adding the player transform vector to an offset vector 3
        transform.position = player.position + offset;
    }
}
