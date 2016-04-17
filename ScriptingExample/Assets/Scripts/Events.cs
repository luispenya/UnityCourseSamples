using UnityEngine;
using System.Collections;

public class Events : MonoBehaviour
{


    // Use this for initialization
    void Awake()
    {
        Debug.Log("Prints Awake!" + Time.time);

    }


    // Use this for initialization
    void Start()
    {
        Debug.Log("Prints Start!" + Time.time);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
            Debug.Log("Prints Fixed!" + Time.time);

        if (Time.time > 2 && Time.time<4)
        {
            gameObject.SetActive(false);
        }
    }
    // Use this for initialization
    void Update()
    {
        Debug.Log("Prints Update!" + Time.time);

        if (Time.time > 4 && Time.time <6)
        {
            gameObject.SetActive(true);
        }
    }



    // Use this for initialization
    void OnDisable()
    {
        Debug.Log("Prints Disabled!" + Time.time);

    }


    // Use this for initialization
    void OnEnable()
    {
        Debug.Log("Prints Enabled!" + Time.time);

    }



}
