using System;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace CarsStore.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Car> _cars;
        

        public DbClient(IOptions<CarsStoreDBConfig> carstoreDBConfig)
        {
            var client = new MongoClient(carstoreDBConfig.Value.Connection_String);
            var database = client.GetDatabase(carstoreDBConfig.Value.Database_Name);
            _cars = database.GetCollection<Car>(carstoreDBConfig.Value.Cars_Collection_name);

        }


        public IMongoCollection<Car> GetCarsCollection() => _cars;
    }
}

