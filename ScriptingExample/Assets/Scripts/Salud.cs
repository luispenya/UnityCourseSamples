using UnityEngine;
using System.Collections;

public class Salud : MonoBehaviour {

    public int salud = 100;
	void Start () {
	
	}
	
	
    public void Descontar(int x)
    {
        salud -= x;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(400, 10, 100, 50), "Salud:"+salud);
    }
}
