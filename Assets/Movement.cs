using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocity = 2f;
    public Rigidbody rb;
    private void Update()
    {
        rb.velocity = Vector3.zero;
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(-velocity, 0, 0);
        }
        else if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(velocity, 0, 0);
        }
        else if (Input.GetKey("w"))
        {
            rb.velocity = new Vector3(0, velocity, 0);
        }
        else if (Input.GetKey("s"))
        {
            rb.velocity = new Vector3(0, -velocity, 0);
        }

    }
}
