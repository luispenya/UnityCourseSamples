using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class PointClickPlane : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject go =
            GameObject.CreatePrimitive(PrimitiveType.Cube);
        go.GetComponent<Renderer>().material.color = Color.red;
        go.transform.position = 
            eventData.pointerCurrentRaycast.worldPosition;

    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
