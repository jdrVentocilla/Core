using System;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Infraestructure.V2
{
    public interface IContext : IDisposable
    {
        Task SaveChangesAsync(CancellationToken cancellationToken);
        void SaveChanges();
        Task RollbackAsync();
        void Rollback();

    }
}
