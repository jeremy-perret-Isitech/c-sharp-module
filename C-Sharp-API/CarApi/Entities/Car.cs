namespace CarApi.Entities
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Model { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Color { get; set; } = string.Empty;
        public string SmartDescription { get; set; } = string.Empty;
        public string FullDescription { get; set; } = string.Empty;
        public double Price { get; set; }
        public string State { get; set; } = string.Empty;
    }
}