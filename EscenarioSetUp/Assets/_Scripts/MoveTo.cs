using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {
    
    
    public Transform goal;
    private NavMeshAgent agent;

    private int runStateHash = Animator.StringToHash("Base Layer.Walk");

    private Animator anim;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        anim = GetComponent<Animator>();
        if (anim!=null)
            anim.SetFloat("Forward", agent.speed);

    }

    void Update()
    {
       /* if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                agent.destination = hit.point;
                
            }
        }
        */
        if (agent.hasPath && agent.remainingDistance < 0.1)
        {
            agent.Stop();
            if (anim != null)
            {
                anim.SetFloat("Forward", 0.0f);
            }
                
            
        }
    }


    
}
