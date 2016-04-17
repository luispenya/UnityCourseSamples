using UnityEngine;
using System.Collections;

public class AlphaBlend : MonoBehaviour {

    Renderer render;

	// Use this for initialization
	void Start () {
        render = GetComponent<Renderer>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            
            RecoveryHP r = gameObject.GetComponent<RecoveryHP>();
            Debug.Log("R" + r);
            if ( r==null)
            {
                r=gameObject.AddComponent<RecoveryHP>();
                r.enabled = false;
                r.hpCurrent = 10;
                r.hpMax = 100;
                r.hpPerSecond = 50;
                r.enabled = true;

                
                
                
            }
            StartCoroutine("Fade");
        }
        
    }

    IEnumerator Fade()
    {
        for (float f = 1f; f >= 0; f -= 0.1f)
        {
            Color c = render.material.color;
            c.a = f;
            render.material.color = c;
            yield return new WaitForSeconds(0.2f);
        }
    }
}
