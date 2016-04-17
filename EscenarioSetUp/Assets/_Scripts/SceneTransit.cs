using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransit : MonoBehaviour {

    public string SceneName;

	void OnTriggerEnter(Collider col)

    {
        if (col.tag == "Player")
        {
            Debug.Log("Entered: " + col.gameObject.name);
            SceneManager.LoadScene(SceneName, LoadSceneMode.Single);

        }
    }
}
