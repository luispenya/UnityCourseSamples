using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

    private bool isOpenDoor = false;
    
    private float speedRotation = 0.08f;

	public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //gameObject.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
            isOpenDoor = true;
            
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //gameObject.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
            isOpenDoor = false;

        }
    }

    public void Update()
    {
        Open(gameObject.transform.GetChild(0).transform.GetChild(0).gameObject);
    }

    public void Open(GameObject DoorPane)
    {
        if (isOpenDoor)
        {
            
            DoorPane.transform.localRotation = Quaternion.Lerp(DoorPane.transform.localRotation,  
                Quaternion.Euler(new Vector3(0,90, 90)),
                Time.time*speedRotation);
        }
        else
        {
            DoorPane.transform.localRotation = Quaternion.Lerp(DoorPane.transform.localRotation,
                Quaternion.Euler(new Vector3(90, 90, 90)),
                Time.time * 1);
        }
    }
}
