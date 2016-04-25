using UnityEngine;
using System.Collections;

public class MiniMapCameraRay : MonoBehaviour {
    private Camera cam;
    private GameObject marker;
	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
        marker = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        marker.transform.localScale = new Vector3(0.5f, 0.1f, 0.5f);
        marker.GetComponent<MeshRenderer>().material.color = Color.yellow;
        GameObject.Destroy(marker.GetComponent<Collider>());
	}
	

	// Update is called once per frame
	void FixedUpdate () {
        //if (Input.GetMouseButton(0))
        //{

        RaycastHit hitInfo;
        int mascara = 1 << 10;
        Ray rayo = cam.ScreenPointToRay(Input.mousePosition);

        
        if (Physics.Raycast(rayo, out hitInfo, 20f,mascara))
        {
            marker.transform.position = hitInfo.point;
            Debug.Log(rayo.direction);

        } else
        {
            Debug.Log("No hit");
        }


        //}
    }
}
