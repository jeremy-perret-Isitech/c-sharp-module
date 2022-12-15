using CarApi.Context;
using CarApi.Entities;
using CarApi.Repository.Interface;

namespace CarApi.Repository.Repository
{
    public class CarRepository: ICarRepository
    {
        private readonly ApplicationDbContext _context;

        public CarRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        async public Task<IEnumerable<Car>> getAllCars()
        {
            return await _context.Cars.Select(car => 
            new Car {
                Id = car.Id,
                Model = car.Model,
                Brand = car.Brand,
                Year = car.Year,
                Color= car.Color,
                SmartDescription = car.SmartDescription,
                FullDescription = car.SmartDescription,
                Price = car.Price,
                State= car.State,
                
            }).ToArrayAsync();
        }

        async public Task<Car> getCarById(Guid carId)
        {
            if (carId == Guid.Empty)
            {
                throw new ArgumentNullException("Guid params is needed");
            }

            var car = await _context.Cars.Where(car => car.Id == carId).Select(car => 
            new Car {
                Id = car.Id,
                Model = car.Model,
                Brand = car.Brand,
                Year = car.Year,
                Color= car.Color,
                SmartDescription = car.SmartDescription,
                FullDescription = car.FullDescription,
                Price = car.Price,
                State= car.State,
                
            }).FirstOrDefaultAsync();

            if (car == null)
            {
                throw new ArgumentNullException("The car with this specified Guid does not exist");
            }

            return car;
        }


        async public Task<Guid> createCar(Car carData)
        {
            if(carData == null)
            {
                throw new ArgumentNullException(nameof(carData));
            }
            if(_context.Cars.Find(carData.Id) != null)
            {
                throw new ArgumentNullException("A car with this specified Guid already exist");
            }

            await _context.Cars.AddAsync(new Car {
                Id = carData.Id,
                Model = carData.Model,
                Brand = carData.Brand,
                Year = carData.Year,
                Color= carData.Color,
                SmartDescription = carData.SmartDescription,
                FullDescription = carData.FullDescription,
                Price = carData.Price,
                State= carData.State,
            });

            await Save();

            return carData.Id;
        }

        async public Task<Car> updateCar(Guid carId, Car carData)
        {
            var entity = _context.Cars.Find(carId);

            if (entity == null)
            {
                throw new ArgumentNullException("The car with this specified Guid does not exist");
            }

            entity.Id = carData.Id;
            entity.Model = carData.Model;
            entity.Brand = carData.Brand;
            entity.Year = carData.Year;
            entity.Color= carData.Color;
            entity.SmartDescription = carData.SmartDescription;
            entity.FullDescription = carData.FullDescription;
            entity.Price = carData.Price;
            entity.State= carData.State;

            await Save();

            return entity;
        }

        async public Task deleteCarById(Guid carId)
        {
            var entity = await _context.Cars.FindAsync(carId);

            if (entity == null)
            {
                throw new ArgumentNullException("The car with this specified Guid does not exist");
            }

            _context.Cars.Remove(entity);

            await Save();

            return;
        }

        async public Task<IEnumerable<Car>> filterCars(FilterOptions filterOptions)
        {
            if(filterOptions == null)
            {
                throw new ArgumentNullException("Filters need to be specified");
            }
            return await _context.Cars
            .Where(car => filterOptions.Model.Contains(car.Model))
            .Where(car => filterOptions.Brand.Contains(car.Brand))
            .Where(car => filterOptions.Color.Contains(car.Color))
            .Where(car => filterOptions.State.Contains(car.State))
            .Where(car => filterOptions.Year.Contains(car.Year))
            .Where(car => filterOptions.SearchField == car.Id.ToString())
            .Where(car => filterOptions.Price == car.Price)
            .Select(car => 
            new Car {
                Id = car.Id,
                Model = car.Model,
                Brand = car.Brand,
                Year = car.Year,
                Color= car.Color,
                SmartDescription = car.SmartDescription,
                FullDescription = car.SmartDescription,
                Price = car.Price,
                State= car.State,
            }).ToArrayAsync();
        }

        async public Task<bool> Save()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}