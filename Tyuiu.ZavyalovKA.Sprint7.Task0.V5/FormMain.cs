using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.ZavyalovKA.Sprint7.Task0.V5
{
    public partial class FormMain : Form
    {
        private List<Product> products = new List<Product>();
        private string dataFilePath = "products.txt";

        public FormMain()
        {
            InitializeComponent();
            UpdateStatusBar();
            LoadSampleData(); 
        }

        // Загружаем тестовые данные
        private void LoadSampleData()
        {
            products.Add(new Product("001", "Молоко", 100, 85.50m, "Молоко 2.5%"));
            products.Add(new Product("002", "Хлеб", 50, 45.00m, "Хлеб белый нарезной"));
            products.Add(new Product("003", "Яйца", 200, 95.00m, "Яйца куриные С0"));
            products.Add(new Product("004", "Сахар", 75, 65.00m, "Сахар песок 1кг"));
            products.Add(new Product("005", "Масло", 30, 120.00m, "Масло сливочное 82%"));

            RefreshDataGridView();
        }

        // Обновляем DataGridView
        private void RefreshDataGridView()
        {
            dataGridViewProducts.Rows.Clear();

            foreach (var product in products)
            {
                dataGridViewProducts.Rows.Add(
                    product.Code,
                    product.Name,
                    product.Quantity,
                    product.Price,
                    product.Description
                );
            }

            UpdateStatusBar();
        }

        // Обновляем статусную строку
        private void UpdateStatusBar()
        {
            toolStripStatusLabelCount.Text = $"Записей: {products.Count}";
            toolStripStatusLabelData.Text = $"Дата: {DateTime.Now:dd.MM.yyyy}";
        }

        // 1. Кнопка "Добавить"
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            // Создаем диалоговое окно для добавления
            FormAddEditProduct form = new FormAddEditProduct();
            form.Text = "Добавить товар";

            if (form.ShowDialog() == DialogResult.OK)
            {
                // Генерируем код (можно улучшить)
                string newCode = (products.Count + 1).ToString("D3");

                Product newProduct = new Product(
                    newCode,
                    form.ProductName,
                    form.Quantity,
                    form.Price,
                    form.Description
                );

                products.Add(newProduct);
                RefreshDataGridView();
                toolStripStatusLabelInfo.Text = "Товар добавлен";
            }
        }

        // 2. Кнопка "Редактировать"
        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для редактирования", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dataGridViewProducts.SelectedRows[0].Index;
            Product selectedProduct = products[selectedIndex];

            FormAddEditProduct form = new FormAddEditProduct();
            form.Text = "Редактировать товар";
            form.ProductName = selectedProduct.Name;
            form.Quantity = selectedProduct.Quantity;
            form.Price = selectedProduct.Price;
            form.Description = selectedProduct.Description;

            if (form.ShowDialog() == DialogResult.OK)
            {
                selectedProduct.Name = form.ProductName;
                selectedProduct.Quantity = form.Quantity;
                selectedProduct.Price = form.Price;
                selectedProduct.Description = form.Description;

                RefreshDataGridView();
                toolStripStatusLabelInfo.Text = "Товар отредактирован";
            }
        }

        // 3. Кнопка "Удалить"
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для удаления", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный товар?",
                                       "Подтверждение удаления",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int selectedIndex = dataGridViewProducts.SelectedRows[0].Index;
                products.RemoveAt(selectedIndex);
                RefreshDataGridView();
                toolStripStatusLabelInfo.Text = "Товар удален";
            }
        }

        // 4. Кнопка "Поиск"
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                RefreshDataGridView();
                return;
            }

            dataGridViewProducts.Rows.Clear();

            foreach (var product in products)
            {
                if (product.Name.ToLower().Contains(searchText) ||
                    product.Code.ToLower().Contains(searchText) ||
                    product.Description.ToLower().Contains(searchText))
                {
                    dataGridViewProducts.Rows.Add(
                        product.Code,
                        product.Name,
                        product.Quantity,
                        product.Price,
                        product.Description
                    );
                }
            }

            toolStripStatusLabelInfo.Text = $"Найдено записей: {dataGridViewProducts.Rows.Count}";
        }

        // 5. Кнопка "Сохранить"
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(dataFilePath))
                {
                    foreach (var product in products)
                    {
                        writer.WriteLine($"{product.Code}|{product.Name}|{product.Quantity}|{product.Price}|{product.Description}");
                    }
                }

                MessageBox.Show("Данные сохранены успешно", "Сохранение",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripStatusLabelInfo.Text = "Данные сохранены в файл";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 6. Кнопка "Загрузить"
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists(dataFilePath))
            {
                MessageBox.Show("Файл данных не найден", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                products.Clear();

                using (StreamReader reader = new StreamReader(dataFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 5)
                        {
                            products.Add(new Product(
                                parts[0],
                                parts[1],
                                int.Parse(parts[2]),
                                decimal.Parse(parts[3]),
                                parts[4]
                            ));
                        }
                    }
                }

                RefreshDataGridView();
                MessageBox.Show("Данные загружены успешно", "Загрузка",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripStatusLabelInfo.Text = "Данные загружены из файла";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 7. Кнопка "Сортировка"
        private void buttonSort_Click(object sender, EventArgs e)
        {
            // Простая сортировка по названию
            products.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            RefreshDataGridView();
            toolStripStatusLabelInfo.Text = "Сортировка по названию";
        }

        // 8. Кнопка "Статистика"
        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            if (products.Count == 0)
            {
                MessageBox.Show("Нет данных для статистики", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalValue = 0;
            int totalQuantity = 0;

            foreach (var product in products)
            {
                totalValue += product.Price * product.Quantity;
                totalQuantity += product.Quantity;
            }

            string stats = $"Общая статистика:\n" +
                          $"Всего товаров: {products.Count}\n" +
                          $"Общее количество: {totalQuantity} шт.\n" +
                          $"Общая стоимость: {totalValue:C}\n" +
                          $"Средняя цена: {totalValue / totalQuantity:C}";

            MessageBox.Show(stats, "Статистика",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 9. Кнопка "График"
        private void buttonChart_Click(object sender, EventArgs e)
        {
            if (products.Count == 0)
            {
                MessageBox.Show("Нет данных для графика", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Показываем простой диалог
            MessageBox.Show("Здесь будет отображен график распределения товаров по количеству или цене.\n" +
                          "Для реализации используйте Chart control из Toolbox.", "График",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 10. Кнопка "Сброс" в панели поиска
        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            RefreshDataGridView();
            toolStripStatusLabelInfo.Text = "Поиск сброшен";
        }

        // 11. Обработчики меню (заглушки)
        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonLoad_Click(sender, e);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSave_Click(sender, e);
        }
    }
}