﻿

namespace Core.InfraestructureOptimized.Espanol
{
    public interface IRepositoryGeneric<T> : IRepositoryAdd<T>, IRepositorySearch<T>, IRepositoryUpdate<T> where T : class
    {

    }
}
