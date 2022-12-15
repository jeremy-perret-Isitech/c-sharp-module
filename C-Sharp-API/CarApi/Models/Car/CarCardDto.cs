namespace CarApi.Models.Cars
{
    public class CarCardDto
    {
        public Guid Id { get; set; }
        public string Model { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public int Year { get; set; }
        public string SmartDescription { get; set; } = string.Empty;
        public double Price { get; set; }
        public string State { get; set; } = string.Empty;
    }
}