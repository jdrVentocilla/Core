
using Core.GestionDeExcepciones;
using System.Collections.Generic;


namespace Core.EntityResult
{
    public class StateExecution<T> where T : class
    {

        public State StateType { get; }
        public bool Status { get; }

        public Message MessageState { get; }
        public List<string> Details { get; }
        public T Data { get; }


        public StateExecution(State state, bool status, T data, string message, string detail = "")
        {
            Status = status;
            Details = new List<string>();
            MessageState = new Message(message, detail);
            Data = data;
            StateType = state;

        }
        public void AddDetail(string mensaje)
        {
            Details.Add(mensaje);

        }

        public void ClearDetails()
        {
            Details.Clear();
        }

        public static StateExecution<T> Ok(T data, string message)
        {

            return new StateExecution<T>(State.Ok, true, data, message);
        }
        public static StateExecution<T> OkNoContent(T data, string message)
        {
            return new StateExecution<T>(State.OkNotContent, true, data, message);
        }

        public static StateExecution<T> ErrorValidation(string message, string detail)
        {
            return new StateExecution<T>(State.ErrorValidation, false, null, message, detail);
        }

        public static StateExecution<T> Error(string message, string detail)
        {
            return new StateExecution<T>(State.Error, false, null, message, detail);
        }
    }

    public class StateExecution
    {

        public State StateType { get; }
        public bool Status { get; }

        public Message MessageState { get; }
        public List<string> Details { get; }


        public StateExecution(State state, bool status, string message, string detail = "")
        {
            MessageState = new Message(message, detail);
            Status = status;
            Details = new List<string>();
            StateType = state;
        }
        public void AddDetail(string mensaje)
        {
            Details.Add(mensaje);
        }

        public void ClearDetail()
        {
            Details.Clear();
        }


        public static StateExecution Ok(string message)
        {
            return new StateExecution(State.Ok, true, message);
        }
        public static StateExecution OkNoContent(string message)
        {
            return new StateExecution(State.OkNotContent, true, message);
        }

        public static StateExecution ErrorValidation(string message, string detail)
        {
            return new StateExecution(State.ErrorValidation, false, message, detail);
        }

        public static StateExecution Error(string message, string detail)
        {
            return new StateExecution(State.Error, false, message, detail);
        }
    }
}
