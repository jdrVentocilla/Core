

namespace Core.InfraestructureOptimized.Espanol
{
    public interface IRepositoryUpdate<T> where T : class
    {
        void Actualizar(T entidad);
        void Eliminar(T entidad);
    }
}
