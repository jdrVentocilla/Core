
using System.Data.Common;


namespace Core.Infraestructure.V1.Repository
{


    public abstract class RepositoryBase

    {
        
        protected DbTransaction transaction;
        protected DbConnection connection;

     
    }
}
