using UnityEngine;
using System.Collections;

public class Danyar : MonoBehaviour {

	
	
	// Update is called once per frame
	void FixedUpdate () {
        	if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Salud>().Descontar(10);
        }
	}
}
