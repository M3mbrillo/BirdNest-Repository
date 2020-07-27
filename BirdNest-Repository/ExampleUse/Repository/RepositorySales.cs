using BirdNest.Repository;
using ExampleUse.Database.Models;

namespace ExampleUse.Repository
{
    internal class RepositorySales : RepositoryEFBase<Sales>
    {

        public override void Delete(Sales entityToDelete)
        {
            throw new System.Exception("You dont Delete a Sale!");
        }

    }
}