using BirdNest.Repository;
using BirdNest.Repository.Core;
using ExampleUse.Database;
using ExampleUse.Database.Models;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace ExampleUse.Repository
{
    class ExampleDbProvider :
        BirdNest.Providers.ProviderEF<Database.ExampleDbContext>
    {
        public ExampleDbProvider(ExampleDbContext dbContext) 
            : base(dbContext)
        {
        }


        //Super generic form
        public IRepositoryBase Book => this.Provider<Book>();

        //A generic for EF 
        public RepositoryEFBase<Author> Author => this.Provider<Author>();

        //A Custom repository
        public RepositorySales Sales => this.Provider<RepositorySales, Sales>();

    }
}
