﻿using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class MovePlayer : NetworkBehaviour
{

    public GameObject bulletPrefab;
    void Update()
    {

      if (!isLocalPlayer)
            return;
            
        var x = Input.GetAxis("Horizontal") * 0.1f;
        var z = Input.GetAxis("Vertical") * 0.1f;

        transform.Translate(x, 0, z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
         //   Fire();
            CmdFire();
        }
    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }


    
    void Fire()
{
    // create the bullet object from the bullet prefab
    var bullet = (GameObject)Instantiate(
        bulletPrefab,
        transform.position - transform.forward,
        Quaternion.identity);

    // make the bullet move away in front of the player
    bullet.GetComponent<Rigidbody>().velocity = -transform.forward * 4;

    // make bullet disappear after 2 seconds
    Destroy(bullet, 2.0f);
}



    [Command]
    void CmdFire()
    {
        // This [Command] code is run on the server!

        // create the bullet object locally
        var bullet = (GameObject)Instantiate(
             bulletPrefab,
             transform.position - transform.forward,
             Quaternion.identity);

        bullet.GetComponent<Rigidbody>().velocity = -transform.forward * 4;

        // spawn the bullet on the clients
        NetworkServer.Spawn(bullet);

        // when the bullet is destroyed on the server it will automaticaly be destroyed on clients
        Destroy(bullet, 2.0f);
    }

}
