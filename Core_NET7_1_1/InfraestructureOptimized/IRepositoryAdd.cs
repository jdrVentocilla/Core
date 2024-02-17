

namespace Core.InfraestructureOptimized
{
    public interface IRepositoryAdd<T> where T : class
    {
        void Add(T entidad);

    }
}
