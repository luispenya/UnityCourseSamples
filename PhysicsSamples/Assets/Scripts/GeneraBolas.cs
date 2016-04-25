using UnityEngine;
using System.Collections;
using UnityEditor;

public class GeneraBolas : MonoBehaviour {
    public GameObject prefabBola;
    public int numBolas;
	// Use this for initialization
	void Start()
    {
       



    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < numBolas / 1000; i++)
        {
            GameObject g = GameObject.Instantiate<GameObject>(prefabBola);
            g.transform.position = new Vector3(i * 0.2f, 20f, i * 0.2f);

        }
        /*
        Debug.Log(Time.deltaTime);
        if (Time.deltaTime>0.10)
        {
            Time.timeScale = 0;
            Debug.Log(Time.time);
        }
     */       
    }
}
