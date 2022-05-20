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

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}