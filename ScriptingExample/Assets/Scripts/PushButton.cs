using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PushButton : MonoBehaviour {

    public GameObject mark;

    public void ClickForMark()
    {
        mark.GetComponent<Text>().text += "MAS ";
    }

}
