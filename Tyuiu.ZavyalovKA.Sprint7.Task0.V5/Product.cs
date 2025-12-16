using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZavyalovKA.Sprint7.Task0.V5
{
    internal class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product(string code, string name, int quantity, decimal price, string description)
        {
            Code = code;
            Name = name;
            Quantity = quantity;
            Price = price;
            Description = description;
        }
    }
}
