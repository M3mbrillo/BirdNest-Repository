using BirdNest.BaseModel;
using BirdNest.Repository.Core;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BirdNest.Repository
{
    //TODO 
    public class RepositoryMongoBase<tDocument> :
        IRepositoryBase<tDocument> where tDocument : class, IId
    {        
        private IMongoDatabase MongoDatabase { get; }

        public string CollectionName { get; }

        public IMongoCollection<tDocument> Documents =>
            this.MongoDatabase.GetCollection<tDocument>(this.CollectionName);

        public RepositoryMongoBase(IMongoDatabase mongoDatabase, string collectionName)
        {
            CollectionName = collectionName; //table
            MongoDatabase = mongoDatabase;
        }

        public void Delete(tDocument entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<tDocument> entitysToDelete)
        {
            throw new NotImplementedException();
        }

        public bool Exist(tDocument entity)
        {
            throw new NotImplementedException();
        }

        public BsonDocument GetAsDocument()
        {
            return this.Documents.ToBsonDocument();
        }

        public IEnumerable<tDocument> Get()
        {
            return this.Documents
                       .Find(x => true)
                       .ToEnumerable<tDocument>();
        }

        public tDocument Save(tDocument entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tDocument> Save(IEnumerable<tDocument> entitys)
        {
            throw new NotImplementedException();
        }

        public Task<tDocument> SaveAsync(tDocument entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<tDocument>> SaveAsync(IEnumerable<tDocument> entitys)
        {
            throw new NotImplementedException();
        }
    }
}
