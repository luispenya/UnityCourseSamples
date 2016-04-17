using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetKey(KeyCode.Alpha1))
        {
            transform.position= new Vector3(-10, 1, 0);
            transform.rotation= Quaternion.AngleAxis(90, Vector3.up);
            
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.SetParent(GameObject.Find("CameraSet2").transform);//,false);
            transform.localRotation = Quaternion.identity;
            transform.localPosition = Vector3.zero;
            transform.localScale = Vector3.one;        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            if (gameObject.name == "Camera3")
            {
                Camera.current.enabled=false;
                
                Camera.SetupCurrent(this.GetComponent<Camera>());
                this.GetComponent<Camera>().enabled = true;
            }
        }
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200,100), "Pos:" + transform.position);
    }
}
