namespace CarApi.Entities
{
    public class FilterOptions 
    {
        public string SearchField { get; set; } = string.Empty;
        public IEnumerable<string> Model { get; set; }
        public IEnumerable<string> Brand { get; set; }
        public IEnumerable<int> Year { get; set; }
        public IEnumerable<string> Color { get; set; }
        public double Price { get; set; }
        public IEnumerable<string> State { get; set; }
    }
}