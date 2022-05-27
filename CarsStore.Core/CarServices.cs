using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace CarsStore.Core
{
    public class CarServices : ICarServices
    {
        private readonly IMongoCollection<Car> _cars;
        public CarServices(IDbClient dbClient)
        {
            _cars = dbClient.GetCarsCollection();
        }

        public Car AddCar(Car car)
        {
            _cars.InsertOne(car);
            return car;
        }

        public void DeleteCar(string id)
        {
            _cars.DeleteOne(car => car.Id == id);
        }

        public Car GetCar(string id) => _cars.Find(car => car.Id == id).First();

        public List<Car> GetCars() => _cars.Find(car => true).ToList();

        public Car UpdateCar(Car car)
        {
            GetCar(car.Id);
            _cars.ReplaceOne(c => c.Id == car.Id, car);
            return car;
        }
    }
}

