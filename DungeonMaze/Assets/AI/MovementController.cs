using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {

    public bool PointClick=false;
    private NavMeshAgent NavigationAgent;


	// Use this for initialization
	void Start () {
        NavigationAgent = GetComponent<NavMeshAgent>();
	}
	
    public float DistanceToTarget(Vector3 tr)
    {
        float dist = 0.0f;
        NavMeshPath path = new NavMeshPath();
        NavMesh.CalculatePath(transform.position, tr, NavMesh.AllAreas, path);
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            Debug.DrawLine(path.corners[i], path.corners[i + 1], Color.red,2f);
            dist+=Vector3.Distance(path.corners[i], path.corners[i + 1]);

        }
        return dist;
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
                        Debug.Log("Distance: " + DistanceToTarget(hit.point));
                }
            }
        }
	}
}
