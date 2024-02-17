namespace Core.GestionDeExcepciones
{
    public class Message
    {
        #region Tipos Enumerados




        #endregion

        #region Atributos Privados
        #endregion

        #region Atributos Publicos
        #endregion

        #region Propiedades
        public string Description { get; set; }
        public string Detail { get; set; }
        public string Action { get; set; }

        #endregion

        #region Constructores


        public Message(string description, string detail)
        {
            this.Description = description;
            this.Detail = detail;

        }

        public Message(string description)
        {
            this.Description = description;
        }


        #endregion

        #region Metodos Privados
        #endregion

        #region Metodos Publicos

        #endregion
    }
}
