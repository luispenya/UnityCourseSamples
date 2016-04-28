using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.Space))
        {
 //           GetComponent<Rigidbody>().AddForce(Vector3.up * 15, ForceMode.Impulse);
            GetComponent<Rigidbody>().AddExplosionForce(50f, transform.position, 4);
        }
	}
}
