using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Core.Infraestructure.V1.Repository
{


    public abstract class RepositoryBase

    {
        
        protected IDbTransaction transaction;
        protected IDbConnection context;

        public abstract IDbCommand CreateCommand(string query);

        public abstract IDbCommand CreateCommand();
       

    }
}
