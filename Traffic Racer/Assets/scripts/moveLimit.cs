using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLimit : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "car")
        {
            Physics.IgnoreCollision(car.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }
}
