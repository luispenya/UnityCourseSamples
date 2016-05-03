using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {

    public bool PointClick=false;
    private NavMeshAgent NavigationAgent;


	// Use this for initialization
	void Start () {
        NavigationAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (PointClick)
        {
            if (Input.GetMouseButton(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                
                if (Physics.Raycast(ray, out hit, 100))
                if (hit.collider.gameObject.CompareTag("Ground"))
                {
                    NavigationAgent.destination = hit.point;
                }
            }
        }
	}
}
