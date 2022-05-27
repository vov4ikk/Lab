using CarsStore.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Lab.Controllers;

[ApiController]
[Route("[controller]")]
public class CarsController : ControllerBase
{
    private readonly ICarServices _carServices;
    public CarsController(ICarServices carServices)
    {
        _carServices = carServices;
    }

    [HttpGet]

    public IActionResult GetCars()
    {
        return Ok(_carServices.GetCars());
    }

    [HttpGet("{id}", Name = "GetCar")]
    public IActionResult GetCar(string id)
    {
        return Ok(_carServices.GetCar(id));

    }


    [HttpPost]
    public IActionResult AddCar(Car car)
    {
        _carServices.AddCar(car);
        return CreatedAtRoute("GetCar", new { id = car.Id }, car);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCar(string id)
    {
        _carServices.DeleteCar(id);
        return NoContent();
    }
    [HttpPut]
    public IActionResult UpdateCar(Car car)
    {
        return Ok(_carServices.UpdateCar(car));
    }
}

