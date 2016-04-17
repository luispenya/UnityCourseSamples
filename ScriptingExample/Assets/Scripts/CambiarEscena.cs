using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections;

public class CambiarEscena : MonoBehaviour {

	void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Salida")
        {
            Debug.Log("Colision!");
            //SceneManager.LoadScene("Scene2");
            GetComponentInParent<Salud>().Descontar(10);
        }
    }
}
