using UnityEngine;
using System.Collections;
using System;

public class FireController : MonoBehaviour {

    public AI.FSM.StateMachine<FireController> fsm;

    public float senseTimer = 0.01f;

    public FireWeapon weapon;
    public bool PointClick = false;


    public Transform target=null;
    public float rotationToTarget=180f;
    public bool LoS=false;

    public void UpdateRotationToTarget()
    {
        if (target)
        {
            Vector3 dirV = target.position - transform.position;
            Quaternion toRotation = Quaternion.LookRotation(dirV);
            rotationToTarget = Quaternion.Angle(transform.rotation,toRotation
                                     );
        }
            
    }

    public bool RotatedToTarget()
    {
        if (!target)
            return false;


        return Mathf.Abs(rotationToTarget) < 15;
    }

    public void UpdateLoSToTarget()
    {
        if (target)
        {
            Ray rayBlast = new Ray(transform.position + new Vector3(0, 1f, 0),
                                        (target.position - transform.position));

            RaycastHit hit;
            if (Physics.Raycast(rayBlast, out hit, 100))
            {
                LoS = hit.collider.gameObject.CompareTag("Player");
            }
        }
        else
        {
            LoS = false;
        }


    }

    public bool IsLoS()
    {
        return LoS;
    }

    private void Sense()
    {
        UpdateLoSToTarget();
        UpdateRotationToTarget();
        
    }

    public void SetTarget(Transform tgt)
    {
        target = tgt;
        fsm.Start();
    }

    internal void RotateToTarget()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position),0.2f);
    }
    void Start()
    {
        fsm = new AI.FSM.StateMachine<FireController>(this, new AI.FSM.Targeting.ReadyState());
    }
    // Update is called once per frame
    void Update()
    {
        if (PointClick)
        {
            if (Input.GetMouseButton(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                    if (hit.collider.gameObject.CompareTag("Player"))
                    {
                        SetTarget( hit.collider.gameObject.transform);
                        
                        
                    }

            }
        }

        Sense();
        fsm.NextAction();
    }   
}
