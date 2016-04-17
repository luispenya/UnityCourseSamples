using UnityEngine;
using System.Collections;

public class Delay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Time.time > 2)
        {
            for (int i = 0; i < Time.time; i++)
            {
                Debug.Log("print mucho.....");

            }
        }
	    
	}
}
