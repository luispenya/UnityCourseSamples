using UnityEngine;
using System.Collections;

public class RayLauncher : MonoBehaviour {

    private Ray rayo;
    private int mascara = 0;
	// Use this for initialization
	void Start () {
        rayo = new Ray(transform.position, transform.TransformDirection(Vector3.up));
       // mascara = 1 << 8;
        mascara = 1 << 9 | 1<<8;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        RaycastHit hit;
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.DrawRay(rayo.origin, rayo.direction, Color.red,20f);
            /*if (Physics.Raycast(rayo, 100, mascara, QueryTriggerInteraction.Collide))
            {
                Debug.Log("Collided!");
            }*/
            if (Physics.Raycast(rayo, out hit,100, mascara,  QueryTriggerInteraction.Collide))
            {
                Debug.Log("Collided!");
                hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                hit.rigidbody.AddForce(rayo.direction * 3f);

                GameObject o =GameObject.CreatePrimitive(PrimitiveType.Sphere);
                o.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                o.GetComponent<MeshRenderer>().material.color = Color.blue;
                o.transform.position = hit.point;

            }
        }
        
	}
}
