using UnityEngine;
using System.Collections;

public class TouchSamples : MonoBehaviour {


    public GameObject cube;

    private Vector3 accel;

    void Update () {

        
        if (Input.touchCount>0)
        {
            Touch toque = Input.GetTouch(0);


            if (toque.phase == TouchPhase.Stationary)
            {
                cube.transform.Translate(cube.transform.forward * Time.deltaTime);
            }
        }

        accel = new Vector3(Input.acceleration.x, Input.acceleration.y, Input.acceleration.z);
        
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), "Acel: " + accel);
    }
}
