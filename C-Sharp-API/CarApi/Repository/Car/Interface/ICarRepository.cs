using CarApi.Entities;

namespace CarApi.Repository.Interface
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> getAllCars();
        Task<Car> getCarById(Guid carId);
        Task<Guid> createCar(Car carData);
        Task<bool> Save();
        Task<Car> updateCar(Guid carId, Car carData);
        Task deleteCarById(Guid carId);
        Task<IEnumerable<Car>> filterCars(FilterOptions carFilterOptions);
    }
}