using UnityEngine;
using System.Collections;

public class FSMControl : MonoBehaviour {


    private AI.FSM.StateMachine<GameObject> fsm;
    public float refresh = 1.0f;
    private float counter;

    private 

	// Use this for initialization
	void Start () {
        counter = refresh;
	}
	
	// Update is called once per frame
	void Update () {
        counter -= Time.deltaTime;
        if (counter < 0)
        {
          /*  Perceive();

            action  = fsm.NextAction();

            Execute(action);

            counter = refresh;
            */
        }
	}
}
