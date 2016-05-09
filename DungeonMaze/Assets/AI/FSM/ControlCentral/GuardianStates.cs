using UnityEngine;
using System.Collections;
/*
namespace AI.FSM.ControlCentral { 
    public class IdleState: State<FSMControl>  {
        public override State<FSMControl> Execute(FSMControl agent)
        {
            if (agent.IsTimeToRun())
            {
                return new PatrolState();
            }
            if (agent.IsHit())
            {
                return new DieState();
            }

            return this;
        }
    }

    public class PatrolState : State<FSMControl>
    {


        public override State<FSMControl> Execute(FSMControl agent)
        {
            if (agent.gameObject.GetComponent<AgentMemory>().patrolLocation==null)
            {
                agent.gameObject.GetComponent<AgentMemory>().patrolLocation = agent.SelectRandomPatrol();
            }

            if (agent.IsReachedPatrolLocation())
            {
                agent.gameObject.GetComponent<AgentMemory>().patrolLocation = agent.SelectRandomPatrol();
            }
            agent.movementController.SetMovementLocation(agent.gameObject.GetComponent<AgentMemory>().patrolLocation);
            if (agent.EnemySight())
            {
                return new AttackState();
            }
            if (agent.IsHit())
            {
                return new DieState();
            }

            return this;
        }

        public override void Exit(FSMControl agent)
        {
            //FIX IT: Hay que gestionar el patrolLocation para ponerlo a una posición que describa que no está definido
            //problema en unity es que Vector3 = null;
            agent.gameObject.GetComponent<AgentMemory>().patrolLocation = new Vector3();
        }
    }

    public class AttackState : State<FSMControl>
    {


        public override State<FSMControl> Execute(FSMControl agent)
        {
            if (agent.IsHit())
            {
                return new DieState();
            }

            agent.fireController.SetTarget(agent.GetEnemy());
            agent.movementController.SetMovementLocation(agent.GetAttackLocation());

            return this;
        }

    
    }

    public class DieState : State<FSMControl>
    {


        public override State<FSMControl> Execute(FSMControl agent)
        {
            agent.Die();

            return null;
        }


    }
}*/