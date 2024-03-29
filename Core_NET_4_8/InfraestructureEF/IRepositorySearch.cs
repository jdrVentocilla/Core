﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;



namespace Core.InfraestructuraEF
{
    public interface IRepositorySearch<T> where T : class
    {
        IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);

        T Find(Expression<Func<T, bool>> filter = null);

        IQueryable<T> Query(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, bool asNoTracking = true);

    }
}
