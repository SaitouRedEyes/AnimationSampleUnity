using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Movement();	
	}

    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.localPosition += Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.localPosition += Vector3.back * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.localPosition += Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.localPosition += Vector3.right * Time.deltaTime;
        }
    }
}
