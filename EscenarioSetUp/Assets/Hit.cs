using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {

	public void Update()
    {
        
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.position     * 20.0f);
       
    }
}
