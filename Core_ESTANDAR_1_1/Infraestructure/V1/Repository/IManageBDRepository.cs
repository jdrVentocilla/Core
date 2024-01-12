

using MySqlConnector;
using System.Data.Common;

namespace Core.Infraestructure.V1.Repository
{
    public interface IManageBDRepository 
    {

        void ExecuteScript(string script);
        void RestoreBackUp(string pathBackUp);
        void RestoreBackUp();

      
    }
}