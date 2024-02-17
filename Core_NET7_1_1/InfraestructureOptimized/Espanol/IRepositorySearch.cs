
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;



namespace Core.InfraestructureOptimized.Espanol
{
    public interface IRepositorySearch<T> where T : class
    {
        IEnumerable<T> Listar(
            Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);

        T Buscar(Expression<Func<T, bool>> filter = null);

        IQueryable<T> Consulta(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, bool asNoTracking = true);

    }
}
