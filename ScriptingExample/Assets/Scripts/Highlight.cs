using UnityEngine;
using System.Collections;

public class Highlight : MonoBehaviour {

    public Color color;
    private Color defaultColor;

    public void Start()
    {
        defaultColor = GetComponent<MeshRenderer>().material.color;
    }
    public void HighLight()
    {
        GetComponent<MeshRenderer>().material.color = color;
    }
    public void OffHighLight()
    {
        GetComponent<MeshRenderer>().material.color = defaultColor;
    }
}
