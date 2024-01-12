
using System.Collections.Generic;
using Core.GestionDeExcepciones;


namespace Core.EntityResult
{
    public class StateExecution<T> where T : class
    {

        public State StateType { get; }
        public bool Status { get; }

        public Message MessageState { get; }
        public List<string> Details { get; }
        public T Data { get; }


        public StateExecution(State state, bool status , string message, T data )
        {
            Status = status;
            Details = new List<string>();
            MessageState = new Message(message);
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

        public static StateExecution<T> Ok (T data , string message)  {

            return new StateExecution<T>(State.Ok, true, message , data);
        }
        public static StateExecution<T> OkNoContent(T data, string message)
        {
            return new StateExecution<T>(State.OkNotContent, true, message, data);
        }

        public static StateExecution<T> ErrorValidation(T data, string message)
        {
            return new StateExecution<T>(State.ErrorValidation, false, message, data);
        }

        public static StateExecution<T> Error(T data, string message)
        {
            return new StateExecution<T>(State.Error, false, message, data);
        }
    }

    public class StateExecution
    {

        public State StateType { get; }
        public bool Status { get;}

        public Message MessageState { get; }
        public List<string> Details { get; }


        public StateExecution(State state, bool status, string message)
        {
            MessageState = new Message(message);
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


        public static StateExecution Ok( string message)
        {
            return new StateExecution(State.Ok, true, message);
        }
        public static StateExecution OkNoContent( string message)
        {
            return new StateExecution(State.OkNotContent, true, message);
        }

        public static StateExecution ErrorValidation(string message)
        {
            return new StateExecution(State.ErrorValidation, false, message);
        }

        public static StateExecution Error( string message)
        {
            return new StateExecution(State.Error, false, message);
        }
    }
}
