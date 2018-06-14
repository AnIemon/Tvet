using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DestroyPlayer : MonoBehaviour
{
    void Start()
    {

    }
    // Enemy hits player changes the screen into a lose screen
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene(1);
        }
    }
    void Update()
    {

    }
    void Spawn()
    {

    }
}
