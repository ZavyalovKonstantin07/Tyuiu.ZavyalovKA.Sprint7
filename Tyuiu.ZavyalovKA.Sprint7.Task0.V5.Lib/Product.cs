using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZavyalovKA.Sprint7.Task0.V5
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product()
        {
        }

        public Product(string code, string name, int quantity, decimal price, string description)
        {
            Code = code;
            Name = name;
            Quantity = quantity;
            Price = price;
            Description = description;
        }

        public decimal CalculateTotalCost()
        {
            return Quantity * Price;
        }

        public bool IsInStock()
        {
            return Quantity > 0;
        }

        public override string ToString()
        {
            return $"{Code} - {Name} ({Quantity} шт. × {Price:C} = {CalculateTotalCost():C})";
        }
    }
}
