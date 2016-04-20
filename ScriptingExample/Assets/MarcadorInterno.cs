using UnityEngine;
using System.Collections;

public class MarcadorInterno : MonoBehaviour {

    public float contador;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        contador = Time.time * 10;
	}
}
