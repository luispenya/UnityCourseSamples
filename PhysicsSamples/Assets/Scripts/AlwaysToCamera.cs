using UnityEngine;
using System.Collections;

public class AlwaysToCamera : MonoBehaviour {
    Camera m_Camera;
	// Use this for initialization
	void Start () {
        m_Camera = Camera.main;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.localRotation = Quaternion.identity;
//        transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward,
//           m_Camera.transform.rotation * Vector3.up);
    }
}
