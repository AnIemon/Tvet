using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGames : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene(2);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
