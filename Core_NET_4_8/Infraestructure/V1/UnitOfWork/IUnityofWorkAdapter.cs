using System;
using System.Threading.Tasks;

namespace Core.Infraestructure.V1.UnitOfWork
{
    public interface IUnityofWorkAdapter : IDisposable
    {

        void SaveChanges();
        void RollBack();
        Task SaveChangesAsync();
        Task RollBackAsync();
    }
}
