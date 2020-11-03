using FoodyCrawler.Entities;

namespace FoodyCrawler.Models
{
    public class Rootobject
    {
        public Reply reply { get; set; }
        public string result { get; set; }
    }

    //public class Reply
    //{
    //    public Menu_Infos[] menu_infos { get; set; }
    //}

    public class Reply
    {
        public MenuModel[] menu_infos { get; set; }
    }

    //public class Menu_Infos
    //{
    //    public int dish_type_id { get; set; }
    //    public string dish_type_name { get; set; }
    //    public Dish[] dishes { get; set; }
    //}

    public class Dish
    {
        public int total_order { get; set; }
        public bool is_deleted { get; set; }
        public string description { get; set; }
        public string display_total_order { get; set; }
        public Price price { get; set; }
        public bool is_active { get; set; }
        public int display_order { get; set; }
        public string total_like { get; set; }
        public object[] properties { get; set; }
        public Photo[] photos { get; set; }
        public Option[] options { get; set; }
        public bool is_available { get; set; }
        public Time time { get; set; }
        public int quantity { get; set; }
        public Discount_Price discount_price { get; set; }
        public int id { get; set; }
        public bool is_group_discount_item { get; set; }
        public string name { get; set; }
    }

    //public class Price
    //{
    //    public int Id { get; set; }
    //    public string text { get; set; }
    //    public string unit { get; set; }
    //    public float value { get; set; }
    //}

    public class Time
    {
        public object[] available { get; set; }
        public Week_Days[] week_days { get; set; }
        public object[] not_available { get; set; }
    }

    public class Week_Days
    {
        public string start { get; set; }
        public int week_day { get; set; }
        public string end { get; set; }
    }

    public class Discount_Price
    {
        public string text { get; set; }
        public string unit { get; set; }
        public int value { get; set; }
    }

    //public class Photo
    //{
    //    public int Id { get; set; }
    //    public int width { get; set; }
    //    public string value { get; set; }
    //    public int height { get; set; }
    //}

    public class Option
    {
        public string ntop { get; set; }
        public bool mandatory { get; set; }
        public int id { get; set; }
        public Option_Items option_items { get; set; }
        public string name { get; set; }
    }

    public class Option_Items
    {
        public int min_select { get; set; }
        public int max_select { get; set; }
        public Item[] items { get; set; }
    }

    public class Item
    {
        public Original_Price original_price { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public Ntop_Price ntop_price { get; set; }
        public int max_quantity { get; set; }
        public int id { get; set; }
        public bool is_default { get; set; }
        public int top_order { get; set; }
        public Price1 price { get; set; }
    }

    public class Original_Price
    {
        public string text { get; set; }
        public float value { get; set; }
        public string unit { get; set; }
    }

    public class Ntop_Price
    {
        public string text { get; set; }
        public int value { get; set; }
        public string unit { get; set; }
    }

    public class Price1
    {
        public string text { get; set; }
        public string unit { get; set; }
        public float value { get; set; }
    }

}
