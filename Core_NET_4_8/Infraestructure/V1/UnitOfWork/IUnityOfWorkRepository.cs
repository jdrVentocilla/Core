

using Core.Infraestructure.V1.Repository;

namespace Core.Infraestructure.V1.UnitOfWork
{
    public interface IUnityOfWorkRepository
    {
        IManageBDRepository ManejoDeBDRepository { get; }


    }
}
