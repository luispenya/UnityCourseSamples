using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class DecirAlgo : RAINAction
{

    public ParticleSystem system;
    public override void Start(RAIN.Core.AI ai)
    {
        system=ai.Body.GetComponentInChildren<ParticleSystem>();
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
        Debug.Log("Algo");
        system.Play();
        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}