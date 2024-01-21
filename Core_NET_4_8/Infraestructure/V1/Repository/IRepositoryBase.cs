
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Infraestructure.V1.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        void Save(T entity);
        void Delete(string id);
        Task<T> FindByIDAsync(string id);
        Task<List<T>> FindAll();


    }
}
