using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Infraestructure.V2
{
    public interface IUnityOfWork : IDisposable
    {

        DbConnection _connection { get; }
        DbTransaction _transaction { get; }
        void SaveChanges();

        Task SaveChangesAsync(CancellationToken cancellationToken);

    }
}
