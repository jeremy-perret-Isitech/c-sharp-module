using Microsoft.AspNetCore.Mvc;
using CarApi.Services.Interface;
using CarApi.Models.Cars;
using CarApi.Models.FilterOptionsDto;

namespace CarApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarController : ControllerBase
{
    private readonly ICarService _carService;

    public CarController(ICarService carService)
    {
        this._carService = carService;
    }

    [HttpGet]
    [HttpHead]
    public async Task<ActionResult<IEnumerable<CarCardDto>>> getAllCars()
    {
        try
        {
            return Ok(await _carService.getAllCars());
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpGet]
    [Route("{carId}")]
    public async Task<ActionResult<CarDetailsDto>> getCarById(Guid carId)
    {
        try
        {
            return Ok(await _carService.getCarById(carId));
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpPut]
    [Route("create")]
    async public Task<ActionResult<Guid>> createCar([FromBody] CarDto carData)
    {
        try
        {
            return Ok(await _carService.createCar(carData));
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpPatch]
    [Route("{carId}/update")]
    public async Task<ActionResult<CarDetailsDto>> updateCar(Guid carId, CarUpdateDto carData)
    {
        try
        {
            return Ok(await _carService.updateCar(carId, carData));
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpDelete]
    [Route("{carId}/delete")]
    public async Task<ActionResult> deleteCarById(Guid carId)
    {
        try
        {
            await _carService.deleteCarById(carId);
            return Accepted();
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpPost]
    [Route("filter")]
    public async Task<ActionResult<IEnumerable<CarCardDto>>> filterCars(FilterOptionsDto filterOptionsDto)
    {
        try
        {
            return Ok(await _carService.filterCars(filterOptionsDto));
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }
}