using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovePlayer : MonoBehaviour
{
    Rigidbody rb;
    const float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
            rb.AddForce(Vector3.forward * speed);
        }
        if(Input.GetKey(KeyCode.S)) {
            rb.AddForce(Vector3.back * speed);
        }
        if(Input.GetKey(KeyCode.A)) {
            rb.AddForce(Vector3.left * speed);
        }
        if(Input.GetKey(KeyCode.D)) {
            rb.AddForce(Vector3.right * speed);
        }
    }
}
