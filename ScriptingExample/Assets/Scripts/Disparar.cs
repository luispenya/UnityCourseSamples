using UnityEngine;

using System.Collections;

public class Disparar : MonoBehaviour {

    public GameObject disparoPrefab;
    private float coolDown = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        coolDown -= Time.deltaTime;
        GameObject blt = null;
        if (Input.GetKey(KeyCode.Space))
        {
            
            if (coolDown < 0)
            {
               blt  = GameObject.Instantiate(disparoPrefab,
                    transform.position + new Vector3(0f, 0.2f, 0f),
                    Quaternion.identity) as GameObject;
                
                coolDown = 0.5f;
            }
        }
        
        //Detectamos que se ha pulsado el espacio
        //Crea una instancia de disparoPrefab.
	//Se desplace perpendicular al objeto en linea recta a velocidad constante.
    // aplicar Traslate al objeto 
	}
}
