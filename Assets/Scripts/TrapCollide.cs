using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCollide : MonoBehaviour
{
    const float forceApplied = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(collision.contacts[0].normal*forceApplied*-1);
        
    }
}
