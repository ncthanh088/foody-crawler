using FoodyCrawler.Models;

namespace FoodyCrawler.Entities
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Price Price { get; set; }

        public Photo[] Photos { get; set; }

        public Category Category { get; set; }
    }
}
