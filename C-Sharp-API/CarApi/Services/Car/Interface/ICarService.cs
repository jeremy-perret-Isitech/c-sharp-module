using CarApi.Models.Cars;
using CarApi.Models.FilterOptionsDto;

namespace CarApi.Services.Interface
{
    public interface ICarService
    {
        Task<IEnumerable<CarCardDto>> getAllCars();
        Task<CarDetailsDto> getCarById(Guid carId);
        Task<Guid> createCar(CarDto carData);
        Task<CarDetailsDto> updateCar(Guid carId, CarUpdateDto carData);
        Task deleteCarById(Guid carId);
        Task<IEnumerable<CarCardDto>>filterCars(FilterOptionsDto filterOptions);
    }
}