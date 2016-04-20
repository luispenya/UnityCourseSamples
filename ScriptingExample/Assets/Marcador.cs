using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Marcador : MonoBehaviour {

    public Text marcador;

	// Use this for initialization
	void Start () {
        marcador.text = "Time 0";
	}
	
	// Update is called once per frame
	void Update () {
        marcador.text = "Time " + Time.time;
	}
}
