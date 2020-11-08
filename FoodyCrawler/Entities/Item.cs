using System.Collections.Generic;

namespace FoodyCrawler.Entities
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Price Price { get; set; }

        public IEnumerable<Photo> Photos { get; set; }

        public Category Category { get; set; }

        public IList<UserItem> UserOrders { get; set; }
    }

    public class Price
    {
        public int Id { get; set; }

        public string text { get; set; }

        public string unit { get; set; }

        public float value { get; set; }
    }

    public class Photo
    {
        public int Id { get; set; }

        public int Width { get; set; }

        public string Value { get; set; }

        public int Height { get; set; }
    }
}
