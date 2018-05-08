using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 20f;
    public float rotationSpeed = 360f;
    public Rigidbody2D rigid;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward, rotationSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward, rotationSpeed);
        }
    
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigid.AddForce(transform.up * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigid.AddForce(-transform.up * speed);
        }
    }

}
