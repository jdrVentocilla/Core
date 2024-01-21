using System;
using System.Data;

namespace Core.Operaciones
{
    public class Enumerado
    {
        public static DataTable ObtenerdtDeTipoEnumerado(Enum tipoEnumerado)
        {
            DataTable dtResultadoDelMetodo = new DataTable();
            dtResultadoDelMetodo.Columns.Add("Código");
            dtResultadoDelMetodo.Columns.Add("Descripción");
            foreach (Enum valor in Enum.GetValues(tipoEnumerado.GetType()))
            {
                dtResultadoDelMetodo.Rows.Add(valor.ToString(), valor.ToString());
            }
            return dtResultadoDelMetodo;
        }
    }
}
