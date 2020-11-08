namespace FoodyCrawler.Models
{
    public class UserOrderModel
    {
        public string Username { get; set; }

        public string SDcode { get; set; }

        public Entities.Item Item { get; set; }

        public int Amount { get; set; }

        public float Price { get; set; }

        public float Total { get; set; }
    }
}
