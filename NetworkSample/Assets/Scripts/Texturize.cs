using UnityEngine;
using System.Collections;

public class Texturize : MonoBehaviour {

   

    public void Texturiza(Material mat)
    {
        gameObject.GetComponent<MeshRenderer>().material = mat;
    }
}
