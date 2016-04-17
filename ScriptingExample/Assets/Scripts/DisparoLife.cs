using UnityEngine;
using System.Collections;

public class DisparoLife : MonoBehaviour {

    public float timeOfLife = 1f;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        timeOfLife -= Time.fixedDeltaTime;
        transform.Translate(new Vector3(0f, 0f, 0.2f));
        if (timeOfLife < 0)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
