using UnityEngine;
using System.Collections.Generic;

public class Moverse : MonoBehaviour {

    public int timeToMove;
    
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(new Vector3(1f * Time.deltaTime * Input.GetAxis("Horizontal"), 0f, 0f));
        }
    }
	
	// Update is called once per frame
	/*void FixedUpdate () {
        //Debug.Log(Time.time);
        if (Time.time < timeToMove) { 
            transform.Translate(new Vector3(0.1f,0,0));
        }
        //Debug.Log(transform.position);
    }*/
}
