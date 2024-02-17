namespace Core.InfraestructureOptimized
{
    public interface IRepositoryUpdate<T> where T : class
    {
        void Update(T entidad);
        void Delete(T entidad);
    }
}
