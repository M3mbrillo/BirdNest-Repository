﻿using BirdNest.BaseModel;
using BirdNest.Providers.Core;
using BirdNest.Repository;
using BirdNest.Repository.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdNest.Providers
{
    public class ProviderEF<TDbContext> : IRepositoryProvider
        where TDbContext : DbContext
    {
        private TDbContext DbContext { get; set; }

        private Dictionary<Type, object> ActivesRepos { get; set; }

        public ProviderEF(TDbContext dbContext)
        {
            this.DbContext = dbContext;
            this.ActivesRepos = new Dictionary<Type, object>();
        }

        public RepositoryEFBase<tEntity> Provider<tEntity>()
            where tEntity : class, IId
        {
            var type = typeof(tEntity);

            if (!ActivesRepos.ContainsKey(type))
                ActivesRepos.Add(type, new RepositoryEFBase<tEntity>(this.DbContext));

            return (RepositoryEFBase<tEntity>)ActivesRepos[type];
        }

        public tRepo Provider<tRepo, tEntity>()
            where tEntity : class, IId
            where tRepo : class, IRepositoryBase
        {
            var type = typeof(tRepo);

            if (!ActivesRepos.ContainsKey(type))
                ActivesRepos.Add(type, Activator.CreateInstance(type, this.DbContext) as tRepo);

            return (tRepo)ActivesRepos[type];
        }


        IRepositoryBase IRepositoryProvider.Provider<tEntity>()
        {
            return this.Provider<tEntity>();
        }

        tRepo IRepositoryProvider.Provider<tRepo, tEntity>()
        {
            return this.Provider<tRepo, tEntity>();
        }
    }
}
