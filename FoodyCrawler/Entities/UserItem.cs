namespace FoodyCrawler.Entities
{
    public class UserItem
    {                
        public  int UserId { get; set; }

        public User User { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int Amount { get; set; }
    }
}
