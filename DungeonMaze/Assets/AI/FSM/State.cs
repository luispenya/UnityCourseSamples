using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI.FSM
{
    public class State<T>
    {
        /*
        private static State<T> Instance=null;

        public static State<T> Create()
        {
            if (Instance==null)
            {
                Instance = new State<T>();
            }
            return Instance;
        }
        */
        public virtual void Enter(T agent) { }

        public virtual State<T> Execute(T agent) { return null; }

        public virtual void Exit(T agent) { }
    }
}
