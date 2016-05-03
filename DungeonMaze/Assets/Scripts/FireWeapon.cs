using UnityEngine;
using System.Collections;

public class FireWeapon : MonoBehaviour {

    public ParticleSystem blast;

    public int ammo=10;
    public float coolDownTime=0.3f;
    public float accuracy = 0.25f;

    private float cooldown = 0.0f;

    

    public void Update()
    {
        cooldown -= Time.deltaTime;
    }

    public bool CoolDownDone()
    {
        return cooldown < 0;
    }

    

    public void Blast(Transform target)
    {
        
        if (ammo > 0)
        {
            if (cooldown < 0)
            {
                ammo--;

                Ray rayBlast = new Ray(transform.position, 
                                        (target.position- transform.position)+(Random.onUnitSphere*accuracy));
                Debug.DrawLine(rayBlast.origin, rayBlast.origin + (rayBlast.direction * 100f), Color.red, 3f);
                blast.Play();
                cooldown = coolDownTime;

            }
        }

        
    }
}
