using System;


namespace Core.GestionDeExcepciones
{
   public class BusinessLogicException : Exception
    {

        public Message mensajeDeValidacion;

        public BusinessLogicException(Message mensaje)
        {
            this.mensajeDeValidacion = mensaje;
        }

        
    }
}
