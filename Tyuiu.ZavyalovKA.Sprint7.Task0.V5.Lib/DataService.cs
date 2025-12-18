using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tyuiu.ZavyalovKA.Sprint7.Task0.V5.Lib
{
    public class DataService
    {
        public bool SaveProductsToFile(List<Product> products, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var p in products)
                    sw.WriteLine($"{p.Code}|{p.Name}|{p.Quantity}|{p.Price}|{p.Description}");
            }
            return true;
        }
        public List<Product> LoadProductsFromFile(string path)
        {
            List<Product> products = new List<Product>();

            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split('|');
                products.Add(new Product(
                    parts[0],
                    parts[1],
                    int.Parse(parts[2]),
                    decimal.Parse(parts[3]),
                    parts[4]
                ));
            }

            return products;
        }
        public string GenerateNextProductCode(List<Product> products)
        {
            if (products.Count == 0) return "001";
            int max = products.Max(p => int.Parse(p.Code));
            return (max + 1).ToString("000");
        }

        public List<Product> SortProductsByName(List<Product> products, bool asc)
        {
            return asc
                ? products.OrderBy(p => p.Name).ToList()
                : products.OrderByDescending(p => p.Name).ToList();
        }

        public List<Product> SortProductsByPrice(List<Product> products, bool asc)
        {
            return asc
                ? products.OrderBy(p => p.Price).ToList()
                : products.OrderByDescending(p => p.Price).ToList();
        }

        public List<Product> SortProductsByQuantity(List<Product> products, bool asc)
        {
            return asc
                ? products.OrderBy(p => p.Quantity).ToList()
                : products.OrderByDescending(p => p.Quantity).ToList();
        }

        public List<Product> FilterProductsByQuantityRange(List<Product> products, int min, int max)
        {
            return products.Where(p => p.Quantity >= min && p.Quantity <= max).ToList();
        }

        public string GetStatistics(List<Product> products)
        {
            return
                $"Всего товаров: {products.Count}\n" +
                $"Общее количество: {products.Sum(p => p.Quantity)}\n" +
                $"Общая стоимость: {products.Sum(p => p.CalculateTotalCost()):C}";
        }
    }
}