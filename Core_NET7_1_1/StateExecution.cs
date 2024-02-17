using Core.GestionDeExcepciones;
using System.Collections.Generic;


namespace Core
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
            this.MessageState = new Message();
            this.Details = new List<string>();
            this.StateType = State.Ok;
        }
        public void AddDetail(string mensaje)
        {
            this.Details.Add(mensaje);

        }

        public void ClearDetails()
        {
            this.Details = new List<string>();
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
            this.MessageState = new Message();
            this.Details = new List<string>();
            this.StateType = State.Ok;
        }
        public void AddDetail(string mensaje)
        {
            this.Details.Add(mensaje);

        }

        public void ClearDetail()
        {
            this.Details = new List<string>();
        }
    }
}
