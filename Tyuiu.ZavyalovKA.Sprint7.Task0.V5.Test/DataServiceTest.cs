using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using Tyuiu.ZavyalovKA.Sprint7.Task0.V5.Lib;

namespace Tyuiu.ZavyalovKA.Sprint7.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTests
    {
        private DataService dataService;
        private List<Product> products;
        private string testFilePath = "test_products.txt";

        [TestInitialize]
        public void Init()
        {
            dataService = new DataService();
            products = new List<Product>
            {
                new Product("001", "Молоко", 10, 50m, "Тест"),
                new Product("002", "Хлеб", 5, 30m, "Тест"),
                new Product("003", "Сахар", 20, 70m, "Тест")
            };
        }

        // Генерация кода

        [TestMethod]
        public void GenerateNextProductCode_ReturnsCorrectCode()
        {
            string nextCode = dataService.GenerateNextProductCode(products);
            Assert.AreEqual("004", nextCode);
        }

        // Сортировка

        [TestMethod]
        public void SortProductsByName_Ascending_WorksCorrectly()
        {
            var sorted = dataService.SortProductsByName(products, true);
            Assert.AreEqual("Молоко", sorted[0].Name);
        }

        [TestMethod]
        public void SortProductsByPrice_Descending_WorksCorrectly()
        {
            var sorted = dataService.SortProductsByPrice(products, false);
            Assert.AreEqual(70m, sorted[0].Price);
        }

        //  Фильтрация

        [TestMethod]
        public void FilterProductsByQuantityRange_ReturnsCorrectCount()
        {
            var filtered = dataService.FilterProductsByQuantityRange(products, 10, 100);
            Assert.AreEqual(2, filtered.Count);
        }

        //  Сохранение и загрузка

        [TestMethod]
        public void SaveAndLoadProducts_FileWorksCorrectly()
        {
            dataService.SaveProductsToFile(products, testFilePath);
            var loaded = dataService.LoadProductsFromFile(testFilePath);

            Assert.AreEqual(products.Count, loaded.Count);
            Assert.AreEqual(products[0].Name, loaded[0].Name);

            if (File.Exists(testFilePath))
                File.Delete(testFilePath);
        }

        // Статистика

        [TestMethod]
        public void GetStatistics_ReturnsCorrectText()
        {
            string stats = dataService.GetStatistics(products);
            Assert.IsTrue(stats.Contains("Всего товаров"));
        }
    }
}