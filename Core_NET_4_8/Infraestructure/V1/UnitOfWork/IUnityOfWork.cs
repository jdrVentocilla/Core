namespace Core.Infraestructure.V1.UnitOfWork
{
    public interface IUnityOfWork<T> where T : IUnityofWorkAdapter
    {
        T Create();
        T Create(string stringConnection);
    }
}
