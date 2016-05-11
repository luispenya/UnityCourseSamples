using UnityEngine;
using System.Collections;

using UnityStandardAssets.CrossPlatformInput;

public class TouchSamples : MonoBehaviour {


    public GameObject cube;

    private Vector3 accel;

    void Update () {

        if (CrossPlatformInputManager.GetAxis("Horizontal") > 0f)
        {
            cube.transform.Translate(new Vector3(0f, CrossPlatformInputManager.GetAxis("Horizontal"), 0f));
        }
        else
        {

            if (Input.touchCount > 0)
            {
                Touch toque = Input.GetTouch(0);


                if (toque.phase == TouchPhase.Stationary)
                {
                    //cube.transform.Translate(cube.transform.forward * Time.deltaTime);

                }
                if (toque.phase == TouchPhase.Moved)
                {
                    cube.transform.Translate(
                        Vector3.Lerp(cube.transform.position,
                        Camera.main.ScreenToWorldPoint(toque.position), 0.1f));

                }

                Touch[] lista = Input.touches;
                for (int i = 0; i < Input.touchCount; i++)
                {
                    Debug.Log("Pinchado" + lista[i].fingerId);
                }
            }

            accel = new Vector3(Input.acceleration.x, Input.acceleration.y, Input.acceleration.z);
            cube.transform.Rotate(accel);

        }
        
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), "Acel: " + accel);
    }
}
