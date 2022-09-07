using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour
{
    public float speed = 1;

    public float horispeed = 1;

    float vertical, horizontal;
    Rigidbody rb;
    textScript script;
    public GameObject carspawner;

    void Start()
    {
        carspawner.SetActive(true);
        rb = GetComponent<Rigidbody>();
        script = GameObject.FindGameObjectWithTag("script").GetComponent<textScript>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector3(horizontal * horispeed, 0, vertical * speed);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "car")
        {
            script.GameOverScreen();
            carspawner.SetActive(false);
        }
    }

}
