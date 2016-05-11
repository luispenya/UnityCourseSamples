using UnityEngine;
using System.Collections;

public class DataLoad : MonoBehaviour {

    public Datos d;
	// Use this for initialization
	void Start () {
        d = new Datos(); 
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.L))
        {
            d.Load();
        }
        if (Input.GetKey(KeyCode.S))
        {
            d.Save();
        }
	}
}
