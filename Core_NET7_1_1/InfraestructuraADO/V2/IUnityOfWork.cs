using System;
using System.Threading;
using System.Threading.Tasks;

namespace Core.InfraestructuraADO.V2
{
    public interface IUnityOfWork : IDisposable
    {
        void SaveChanges();

        Task SaveChangesAsync(CancellationToken cancellationToken);

    }
}
