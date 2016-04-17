using UnityEngine;
using System.Collections;

public class CrearMuro : MonoBehaviour {

    public float runtimeFreq = 0.0f;
    private float counter = 0f;
    private int currentRow = 0;
    private int currentCol = 0;
    private int currentWall = 0;
    private GameObject m=null;
    void Start()
    {
        counter = runtimeFreq;
        m = CrearMuroNuevo(currentWall); 
        if (runtimeFreq == 0)
        {
            float x = 0f;
            float z = 0f;

            for (int i = 0; i < 4; i++)
            {
                GameObject muro = new GameObject("Muro" + i);
                switch (i)
                {
                    case 0:
                        x = 0;
                        z = 0;
                        break;
                    case 1:
                        x = 2.85f;
                        z = -0.15f;
                        break;
                    case 2:
                        x = 2.70f;
                        z = -3f;
                        break;
                    case 3:
                        x = -0.15f;
                        z = -2.85f;
                        break;

                }

                muro.transform.position = new Vector3(x, 0, z);
                muro.transform.Rotate(Vector3.up, 90f * i);
                Muro(muro);



            }
        }
    }

	// Use this for initialization
	void Muro (GameObject parent) {
        float x = 0f;
        float y = 0f;
        
        for (int j=0; j<6; j++)
        {
            x = 0f;
            for (int i = 0; i < 6; i++)
            {
                Muro(parent, x, y);
                
                x += 0.5f;
            }
            y += 0.3f;
        }
	    

	}

    void Muro(GameObject parent,float x, float y)
    {
        GameObject l = GameObject.CreatePrimitive(PrimitiveType.Cube);
        l.transform.parent = parent.transform;

        Rigidbody rb= l.AddComponent<Rigidbody>();
        rb.mass = 0.1f;
        l.transform.localScale = new Vector3(0.5f, 0.3f, 0.2f);
        l.transform.localRotation = Quaternion.identity;
        l.transform.localPosition = new Vector3(x, y, 0);
    }
	
    private GameObject CrearMuroNuevo(int i)
    {
        float x = 0;
        float z = 0;
        switch (i)
        {
            case 0:
                x = 0;
                z = 0;
                break;
            case 1:
                x = 2.85f;
                z = -0.15f;
                break;
            case 2:
                x = 2.70f;
                z = -3f;
                break;
            case 3:
                x = -0.15f;
                z = -2.85f;
                break;

        }
        GameObject muro = new GameObject("Muro" + i);


        muro.transform.position = new Vector3(x, 0, z);
        muro.transform.Rotate(Vector3.up, 90f * i);
        return muro;
    }

    // Update is called once per frame
    void Update () {
	    if (runtimeFreq > 0f && currentWall<4)
        {

            
            counter -= Time.deltaTime;
            if (counter <= 0)
            {
                Muro(m, currentCol * 0.5f, currentRow * 0.3f);
                currentCol += 1;
                if (currentCol > 5)
                {
                    currentCol = 0;
                    currentRow += 1;
                }
                if (currentRow > 2)
                {
                    currentRow = 0;
                    currentWall += 1;
                    m = CrearMuroNuevo(currentWall);
                }
                
                

                counter = runtimeFreq;
            }
        }
	}
}
