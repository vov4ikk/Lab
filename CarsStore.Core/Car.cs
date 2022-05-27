using MongoDB.Bson.Serialization.Attributes;
namespace CarsStore.Core
{
	public class Car
	{
		[BsonId]
		[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

		public string Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public string Model { get; set; }
	}
}


