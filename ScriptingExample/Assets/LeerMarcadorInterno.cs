using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeerMarcadorInterno : MonoBehaviour {

    public MarcadorInterno refMarcador=null;
    private Text texto;
	// Use this for initialization
	void Start () {
	    if (refMarcador == null)
        {
            refMarcador = GameObject.Find("Marcador").GetComponent<MarcadorInterno>();
        }
        texto = GetComponent<Text>();
	}
	
	void OnGUI()
    {
        texto.text = "Valor: "+refMarcador.contador;
    }
}
