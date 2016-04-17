using UnityEngine;
using System.Collections;

public class RecoveryHP : MonoBehaviour {

    public int hpCurrent;
    public int hpMax;
    public int hpPerSecond;

	void OnEnable()
    {
   /*
        hpCurrent = 10;
        hpMax = 100;
        hpPerSecond = 50;*/
        StartCoroutine(Recover());

    }

    

    public void OnGUI()
    {
        GUI.Label(new Rect(50, 50, 100, 100), "HP: " + hpCurrent);
    }

    IEnumerator Recover()
    {

        while (hpCurrent < hpMax)
        {
            hpCurrent += hpPerSecond/10;
            yield return new WaitForSeconds(0.1f);
        }
        this.enabled = false;
        Destroy(this);
    }
}
