using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, -1000 * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0, 0, -1000 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0, 0, 1000 * Time.deltaTime);
        }
    }
}