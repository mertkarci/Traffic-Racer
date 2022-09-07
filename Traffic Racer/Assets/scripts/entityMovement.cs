using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entityMovement : MonoBehaviour
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
        if (col.gameObject.tag == "roadcube")
        {
            Destroy(gameObject);
        }
    }
}