using UnityEngine;
using System.Collections;

public class CrearCosas : MonoBehaviour {

    public GameObject plantillaMovil;

	// Use this for initialization
	void Start () {
        /*GameObject o = GameObject.CreatePrimitive(PrimitiveType.Cube);
        o.transform.position = new Vector3(0, 2, 2);
        o.AddComponent<Moverse>();*/

        GameObject o = GameObject.Instantiate(plantillaMovil) as GameObject;
        GameObject b = GameObject.Instantiate<GameObject>(GameObject.Find("Cosa"));
        GameObject c = GameObject.Instantiate(Resources.Load("Movil")) as GameObject;
        c.transform.position = new Vector3(0, 2, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
