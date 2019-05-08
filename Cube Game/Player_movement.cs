
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    
    public float forwardForce = 2000f; // f means that it is a float number
    public float sidewaysForce = 500f;
    public Rigidbody Rb;

    // Start is called before the first frame update


    void Start()
    {
        Debug.Log(" Hello World ");
        /*
        Rb.AddForce(0, 200, 500);
        */
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKey("w"))
        {
            Rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if(Input.GetKey("d"))
        {
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("s"))
        {
            Rb.AddForce(0, 0, -forwardForce*Time.deltaTime);
        }
        
    }
}
