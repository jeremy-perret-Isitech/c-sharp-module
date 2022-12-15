using AutoMapper;
using CarApi.Models.Cars;
using CarApi.Models.FilterOptionsDto;
using CarApi.Repository.Interface;
using CarApi.Services.Interface;
using CarApi.Entities;

namespace CarApi.Services.Service
{
    public class CarService: ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarService(IMapper mapper, ICarRepository carRepository)
        {
            _mapper = mapper;
            _carRepository = carRepository;
        }

        async public Task<IEnumerable<CarCardDto>> getAllCars()
        {
            return _mapper.Map<IEnumerable<CarCardDto>>(await _carRepository.getAllCars());
        }

        async public Task<CarDetailsDto> getCarById(Guid carId)
        {
            return _mapper.Map<CarDetailsDto>(await _carRepository.getCarById(carId));
        }

        async public Task<Guid> createCar(CarDto carDtoData)
        {
            var carEntity = _mapper.Map<Car>(carDtoData);
            return await _carRepository.createCar(carEntity);;
        }

        async public Task<CarDetailsDto> updateCar(Guid carId, CarUpdateDto carData)
        {
            var carEntity = _mapper.Map<Car>(carData);
            return _mapper.Map<CarDetailsDto>(await _carRepository.updateCar(carId, carEntity));
        }

        async public Task deleteCarById(Guid carId)
        {
            await _carRepository.deleteCarById(carId);
            return;
        }

        async public Task<IEnumerable<CarCardDto>> filterCars(FilterOptionsDto filterOptionsDto)
        {
            var filterOptions = _mapper.Map<FilterOptions>(filterOptionsDto);
            return _mapper.Map<IEnumerable<CarCardDto>>(await _carRepository.filterCars(filterOptions));
        }
    }
}