using CarApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarApi.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) {}

        public DbSet<Car> Cars { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<Car>().HasData(
                new Car {Id = new Guid("d581da4c-aa05-454c-b2f7-7be925c158d1") , Model = "AU-167", Brand="Audi", Year = 2017, Color="Black", SmartDescription= "A smart description", FullDescription= "A full description with many informations", Price= 12000.00, State= "New"},
                new Car {Id = Guid.NewGuid(), Model = "FD-777", Brand="Ford", Year = 2008, Color="Orange", SmartDescription= "A smart description", FullDescription= "A full description with many informations", Price= 125900.00, State= "Good condition"},
                new Car {Id = Guid.NewGuid(), Model = "FD-689", Brand="Ford", Year = 2012, Color="Red", SmartDescription= "A smart description", FullDescription= "A full description with many informations", Price= 1100, State= "Wreck"},
                new Car {Id = Guid.NewGuid(), Model = "BM-045", Brand="BMW", Year = 2017, Color="Blue", SmartDescription= "A smart description", FullDescription= "A full description with many informations", Price= 15000, State= "New"},
                new Car {Id = Guid.NewGuid(), Model = "OP-001", Brand="Opel", Year = 2010, Color="Black", SmartDescription= "A smart description", FullDescription= "A full description with many informations", Price= 4000, State= "Good condition"},
                new Car {Id = Guid.NewGuid(), Model = "DC-258", Brand="Dacia", Year = 2011, Color="White", SmartDescription= "A smart description", FullDescription= "A full description with many informations", Price= 6500, State= "Good condition"},
                new Car {Id = Guid.NewGuid(), Model = "LR-777", Brand="Land Rover", Year = 2015, Color="Brown", SmartDescription= "A smart description", FullDescription= "A full description with many informations", Price= 8420, State= "Good condition"}
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}