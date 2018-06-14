using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Destroy : MonoBehaviour
{

    void Start()
    {

    }
    // Destroys the enemy when it collides with an object
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    void Spawn()
    {

    }
}
