using UnityEngine;
using System.Collections;

public class MueveBola : MonoBehaviour {

    public Rigidbody[] rb;
    private float cooldown=0.5f;
    

    // Use this for initialization
	
	// Update is called once per frame
	void FixedUpdate () {
        cooldown -= Time.fixedDeltaTime;
        if (cooldown > 0)
            return;

        
	    if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Aplicando Fuerza " + Vector3.forward * 4);
            rb[0].AddForce(Vector3.forward * 4, ForceMode.Force);
            rb[1].AddForce(Vector3.forward * 4, ForceMode.Acceleration);
            rb[2].AddForce(Vector3.forward * 4, ForceMode.Impulse);
            rb[3].AddForce(Vector3.forward * 4, ForceMode.VelocityChange);
            cooldown = 0.5f;
        }
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 20), "Velocidad 0" + rb[0].velocity);
        GUI.Label(new Rect(10, 30, 300, 20), "Velocidad 1" + rb[1].velocity);
        GUI.Label(new Rect(10, 50, 300, 20), "Velocidad 2" + rb[2].velocity);
        GUI.Label(new Rect(10, 70, 300, 20), "Velocidad 3" + rb[3].velocity);
    }
}
