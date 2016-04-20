using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ActionButton : MonoBehaviour {

	public void GoToScene_1()
    {
        Debug.Log("Goto 1");
        SceneManager.LoadScene(1);
    }

    public void GetText()
    {
        GameObject go = GameObject.Find("CampoDeDatos");
        Debug.Log(go.GetComponent<Text>().text);
    }

    public void GetTextEnd()
    {
        GameObject go = GameObject.Find("CampoDeDatos");
        Debug.Log("ACABA:"+go.GetComponent<Text>().text);
    }
}
