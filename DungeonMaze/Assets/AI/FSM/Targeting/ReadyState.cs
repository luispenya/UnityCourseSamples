using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace AI.FSM.Targeting
{
    class ReadyState : AI.FSM.State<FireController>
    {
        public override void Enter(FireController agent)
        {
            agent.gameObject.GetComponent<AgentMemory>().rawMemory["OutOfAmmo"] = 0;
            agent.gameObject.GetComponent<AgentMemory>().rawMemory["LoSLost"] = 0;
        }


        public override State<FireController> Execute(FireController agent)
        {
            Debug.Log("Ready State - " + agent.gameObject.name);
            if (agent.weapon.CoolDownDone())
            {
                if (agent.weapon.ammo == 0) {
                    return new OutOfAmmoState();
                } else
                {
                    return new TargetingState();
                }
                
            }
            return this;
        }

       
    }

    public class OutOfAmmoState : AI.FSM.State<FireController>
    {
        

        public override State<FireController> Execute(FireController agent)
        {
            Debug.Log("Ammo Depleted! (" + agent.gameObject.name + ")");
            agent.gameObject.GetComponent<AgentMemory>().rawMemory["OutOfAmmo"] = 1;

            return null;
        }

    }

    public class TargetingState : AI.FSM.State<FireController>
    {
        
        public override State<FireController> Execute(FireController agent)
        {

            Debug.Log("Rotating to Target " + agent.target.transform);
            agent.RotateToTarget();
            if (agent.IsLoS())
            { 
                if (agent.RotatedToTarget())
                {

                    return new FireState();
                } 
            } else
            {
                return new LoSLostState();
            }
            return this;
        }

    }

    public class LoSLostState : AI.FSM.State<FireController>
    {
        public override State<FireController> Execute(FireController agent)
        {
            Debug.Log("LoS Lost (" + agent.gameObject.name + ")");
            agent.gameObject.GetComponent<AgentMemory>().rawMemory["LoSLost"] = 1;

            return null;
        }
    }

    public class FireState : AI.FSM.State<FireController>
    {
        //Estado terminal que implica que se realiza el disparo
        public override State<FireController> Execute(FireController agent)
        {
            agent.weapon.Blast(agent.target);
            return null;

        }

       
    }

}
