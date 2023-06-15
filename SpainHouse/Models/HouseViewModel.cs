namespace SpainHouse.Models
{
    public class HouseViewModel
    {
        public string Id { get; set; } = "";
        public string Town { get; set; } = "";
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int Area { get; set; }
        public int BedroomsCount { get; set; }
        public int Terrace { get; set; }
        public List<string> ImageUrls { get; set; } = new List<string>();
    }
}
