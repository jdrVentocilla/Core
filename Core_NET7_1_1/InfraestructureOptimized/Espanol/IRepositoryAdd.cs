

namespace Core.InfraestructureOptimized.Espanol
{
    public interface IRepositoryAdd<T> where T : class
    {
        void Agregar(T entidad);

    }
}
