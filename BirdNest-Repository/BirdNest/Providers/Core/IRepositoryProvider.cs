using BirdNest.BaseModel;
using BirdNest.Repository.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdNest.Providers.Core
{
    public interface IRepositoryProvider
    {
        IRepositoryBase Provider<TEntity>()
            where TEntity : class, IId;

        TRepo Provider<TRepo, TEntity>()
            where TRepo : class, IRepositoryBase
            where TEntity : class, IId;
    }
}
