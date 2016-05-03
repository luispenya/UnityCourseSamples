using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI.FSM
{
    public class StateMachine<T>
    {
        private T owner;

        private State<T> currentState=null;
        private State<T> previousState=null;

        private State<T> initialState = null;

        public StateMachine(T own, State<T> initSt)
        {
            owner = own;
            initialState = initSt;

        }


        public void NextAction() {
            State<T> newState;
            if (currentState != previousState)
            {
                if (previousState != null)
                {
                    previousState.Exit(owner);
                }
                if (currentState != null)
                {
                    currentState.Enter(owner);
                }
                

            }
            if (currentState != null)
            {
                newState = currentState.Execute(owner);
                if (newState == null)
                {
                    currentState = initialState;
                    previousState = null; 
                }
                if (currentState != newState)
                {
                    previousState = currentState;
                    currentState = newState;
                }
            }
                
        }

        internal void Start()
        {
            currentState = initialState;
            previousState = null;
        }
    }
}
