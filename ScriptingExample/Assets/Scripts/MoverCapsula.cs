using UnityEngine;
using System.Collections;

public class MoverCapsula : MonoBehaviour {

    public float velocidad=1f; //en metros por segundo
	
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * velocidad;

        transform.Translate(new Vector3(x, 0f, z));
            
	// Vamos a menejar Input.(...)
    // Aplicar Traslate a la transformada del objeto 
    // Ajustar la velocidad con Time.deltaTime
	}
}
