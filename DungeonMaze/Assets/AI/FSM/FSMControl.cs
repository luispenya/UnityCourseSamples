using UnityEngine;
using System.Collections;

public class FSMControl : MonoBehaviour {


    private AI.FSM.StateMachine<FSMControl> fsm;
    public float refresh = 1.0f;
    private float counter;

    public FireController fireController;
    public MovementController movementController;

    private float timer = 0.0f;

    public bool IsTimeToRun()
    {
        //Timer es un atributo que representa el 
        //tiempo transcurrido desde que el agente se ha activado
        return timer > 1.0f;
    }

	// Use this for initialization
	void Start () {
        counter = refresh;
        timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

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
