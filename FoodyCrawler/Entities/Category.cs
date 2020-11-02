using System.Collections.Generic;

namespace FoodyCrawler.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Item> Items { get; set; }
    }
}
