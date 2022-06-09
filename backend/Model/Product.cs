using System;

namespace Model
{
    public class Product
    {
        public Product() {}

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
    }
}