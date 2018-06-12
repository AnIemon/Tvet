using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ray InteractRay;
            InteractRay = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            RaycastHit hitInfo;
            if (Physics.Raycast(InteractRay, out hitInfo, 10))
            {
                if (hitInfo.collider.CompareTag("Enemy"))
                {
                    Debug.Log("Hit Enemy");
                }
            }
        }
    }
}
