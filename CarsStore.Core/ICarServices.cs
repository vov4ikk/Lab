using System;
using System.Collections.Generic;

namespace CarsStore.Core
{
	public interface ICarServices
	{
		List<Car> GetCars();
		Car GetCar(string id);
		Car AddCar(Car car);

		void DeleteCar(string id);
		Car UpdateCar(Car car);
	}
}

