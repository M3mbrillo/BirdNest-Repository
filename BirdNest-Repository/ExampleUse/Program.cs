using BirdNest.Providers;
using ExampleUse.Database;
using ExampleUse.Database.Models;
using System;
using System.Runtime.CompilerServices;

namespace ExampleUse
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO config the DbContext, models, relationships, conn string...

            //TODO A magic DI the used on ASP.NET Core...
            using var dbContext = new ExampleUse.Database.ExampleDbContext();            
            
            //Easy way using a explicit provider
            var repo = new Repository.ExampleDbProvider(dbContext);
            
            var test1 = repo.Book.Exist(1); // IRepositoryBase , only work with object 
            var test2 = repo.Author.Get(x => x.Name.StartsWith("Patr")); // RepositoryEFBase<Author>()
            repo.Sales.Delete(new Sales { Id = 1 }); // RepositorySales -> exception as example


            //bad way using the provider base
            var repoProvider = new ProviderEF<ExampleDbContext>(dbContext);

            var bookRepository = repoProvider.Provider<Book>();            
        }
    }
}
