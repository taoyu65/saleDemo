using System;
namespace saleDemo.Models
{
    public class Cart
    {
        private int id;
        private int user_id;
        private int item_id;

        public Cart()
        {
        }

        public int Id { get => id; set => id = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public int Item_id { get => item_id; set => item_id = value; }
    }
}
