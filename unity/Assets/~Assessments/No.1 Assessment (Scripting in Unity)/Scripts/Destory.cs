using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
    void OnCollisonEnter(Collison collison)
    {
        timer++;
        if (collison.gameObject.tag == "Ground")
        {
            Destroy(collison.gameObject);
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
