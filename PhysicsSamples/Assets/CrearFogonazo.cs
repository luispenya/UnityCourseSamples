using UnityEngine;
using System.Collections;

public class CrearFogonazo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.Space))
        {
            GameObject flare = transform.FindChild("Flare").gameObject;
            flare.GetComponent<ParticleSystem>().Play(true);
        }
	}
}
