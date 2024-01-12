
using System.Collections.Generic;
using Core.GestionDeExcepciones;


namespace Core.EntityResult
{
    public class StateExecution<T>
    {

        public State StateType { get; set; }
        public bool Status { get; set; }

        public Message MessageState { get; set; }
        public List<string> Details { get; set; }
        public T Data { get; set; }


        public StateExecution()
        {
            MessageState = new Message();
            Details = new List<string>();
            StateType = State.Ok;
        }
        public void AddDetail(string mensaje)
        {
            Details.Add(mensaje);

        }

        public void ClearDetails()
        {
            Details = new List<string>();
        }



    }

    public class StateExecution
    {

        public State StateType { get; set; }
        public bool Status { get; set; }

        public Message MessageState { get; set; }
        public List<string> Details { get; set; }


        public StateExecution()
        {
            MessageState = new Message();
            Details = new List<string>();
            StateType = State.Ok;
        }
        public void AddDetail(string mensaje)
        {
            Details.Add(mensaje);

        }

        public void ClearDetail()
        {
            Details = new List<string>();
        }
    }
}
