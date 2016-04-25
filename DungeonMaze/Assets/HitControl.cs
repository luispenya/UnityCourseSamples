using UnityEngine;
using System.Collections;

public class HitControl : MonoBehaviour {

    private GameObject model;
    private Animator anim;

	// Use this for initialization
	void Start () {
        model = transform.FindChild("Model").gameObject;
        anim = model.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            if (anim.IsInTransition(0))
                anim.SetBool("jump", true);
            /*if (!model.GetComponent<Animation>().IsPlaying("Shield_hit_A"))
            {
                model.GetComponent<Animation>().Play("Shield_hit_A", PlayMode.StopAll);
            }*/
            model.GetComponent<Animator>().SetBool("jump", false);
        }
	    
	}
}
