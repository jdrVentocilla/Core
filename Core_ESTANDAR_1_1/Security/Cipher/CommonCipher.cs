using System;
using System.Text;


namespace Core.Seguridad.Cifrado
{
   public  class CommonCipher

    {

        #region Atributos Privados
        #endregion

        #region Atributos Publicos
        #endregion

        #region Propiedades
        #endregion

        #region Constructores

        #endregion

        #region Metodos Privados
        #endregion

        #region Metodos Publicos

        public static string Encrypt(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
          
            return Convert.ToBase64String(bytes, 0, bytes.Length);
        }

        public static string Decrypt(string textEncrypt)
        {
            byte[] inputBuffer = Convert.FromBase64String(textEncrypt);
           
            return Encoding.UTF8.GetString(inputBuffer);
        }

        #endregion

    }
}
