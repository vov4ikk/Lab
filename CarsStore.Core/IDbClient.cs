using System;
using MongoDB.Driver;
namespace CarsStore.Core
{
	public interface IDbClient
	{
		IMongoCollection<Car> GetCarsCollection(); 
	}
}

