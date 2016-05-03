using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public class StateMachine
    {
        private Agent owner;
        private State current_state;

        public Action Execute()//Cual es la siguiente accion??
        {
            current_state.Execute();

        }
    }


    class State
    {
        public State(Agent )
        {
                
        }

        public Action Enter()
        {

        }
        public Action Execute()
        {

        }
        public Action Exit()
        { }

    }

    class Huir : State
    {
        public Huir()
        {
            //inicialiazar estado??
        }
        public Action Enter()
        {
            return //Action a realizar al empezar el estado
        }
        public Action Execute()
        {
            Action a_ejecutar;//Diremos que acciones queremos hacer
            if (Condicion de salida1){
                StateMachine.current_state = new Esperar();
                a_ejeuctar=this.Exit();
            } else 
            if (condicion_ de salida 2){
                StateMachine.current_State = new OtroState();
                a_ejecutar=this.Exit();
            }
            return a_ejecutar;

        }
        public Action Exit()
        {
            return //Action de salida;
        }
    }

    class Esperar: State
    {
        public Esperar() { }
        public Action Execute()
        {
            Action
        }
    }
}
