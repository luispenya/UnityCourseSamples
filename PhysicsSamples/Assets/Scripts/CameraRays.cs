using UnityEngine;
using System.Collections;

public class CameraRays : MonoBehaviour {
    public Texture2D pointer;

	// Use this for initialization
	void Start () {
        Cursor.SetCursor(pointer, new Vector2(pointer.height / 2.0f, pointer.height / 2.0f), CursorMode.Auto);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if (Input.GetMouseButton(0))
        {
            Ray rayo =Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(rayo,out hit))
            {
                GameObject o = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                o.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                o.GetComponent<MeshRenderer>().material.color = Color.green;
                o.transform.position = hit.point;
            }
        }
        
	}
}
