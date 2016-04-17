using UnityEngine;
using System.Collections;

public class WindOnCloth : MonoBehaviour {

    public Cloth pieceOfCloth;
    public WindZone wZ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("TR"+wZ.transform.forward);

            Vector3 str = -wZ.transform.forward * wZ.windMain*20;
            pieceOfCloth.randomAcceleration = str;
        
	}
}
