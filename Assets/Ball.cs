using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
