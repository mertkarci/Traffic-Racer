using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadMovement : MonoBehaviour
{
    Rigidbody rb;
    public float scrollspeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector3(0, 0, scrollspeed);
        rb.angularVelocity = new Vector3(0, 0, 0);
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "roadcube")
        {
            transform.position = new Vector3(6.845927f, 20.5411f, 4.9f);
        }
    }
}
