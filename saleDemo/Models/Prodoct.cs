using System;
using System.Data.SqlTypes;
using System.ComponentModel.DataAnnotations;
namespace saleDemo.Models
{
    public class Prodoct
    {
        private int id;
        private string name;
        private double price;
        private double discountedPrice;
        private string description;
        private byte[] product_create_time;
        private byte[] create_time;
        private byte[] update_time;

        public Prodoct()
        {
        }

        public int Id { get => Id; set => Id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public double DiscountedPrice { get => discountedPrice; set => discountedPrice = value; }
        public string Description { get => description; set => description = value; }

        [Timestamp]
        public byte[] Product_create_time { get => product_create_time; set => product_create_time = value; }

        [Timestamp]
        public byte[] Create_time { get => create_time; set => create_time = value; }

        [Timestamp]
        public byte[] Update_time { get => update_time; set => update_time = value; }
    }
}
