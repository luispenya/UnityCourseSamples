using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {
    public GameObject[] enemies;
    public float respawn_time;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator Spawn()
    {

        yield return new WaitForSeconds(respawn_time);
    }
}
