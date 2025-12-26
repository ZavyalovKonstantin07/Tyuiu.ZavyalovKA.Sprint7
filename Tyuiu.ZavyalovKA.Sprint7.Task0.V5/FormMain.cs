using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tyuiu.ZavyalovKA.Sprint7.Task0.V5.Lib;

namespace Tyuiu.ZavyalovKA.Sprint7.Task0.V5
{
    public partial class FormMain : Form
    {
        private List<Product> products = new List<Product>();
        private List<Product> originalProducts = new List<Product>();
        private bool isSorted = false;
        private int sortMode = -1; // -1 = не сортировано, 0 = имя, 1 = количество, 2 = цена

        private readonly string dataFilePath = "products.csv";
        private readonly string backupFilePath = "products_backup.csv";
        private readonly DataService dataService = new DataService();

        public FormMain()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadData();
            InitializeEventHandlers();
        }

        private void ConfigureDataGridView()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
            CodeColumn.DataPropertyName = "Code";
            NameColumn.DataPropertyName = "Name";
            QuantityColumn.DataPropertyName = "Quantity";
            PriceColumn.DataPropertyName = "Price";
            DescriptionColumn.DataPropertyName = "Description";

            // Настраиваем форматирование
            QuantityColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            PriceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            PriceColumn.DefaultCellStyle.Format = "C2";
        }

        private void InitializeEventHandlers()
        {
            // Кнопки панели инструментов
            buttonAddProduct.Click += ButtonAddProduct_Click;
            buttonEditProduct.Click += ButtonEditProduct_Click;
            buttonDeleteProduct.Click += ButtonDeleteProduct_Click;
            buttonSearch.Click += ButtonSearch_Click;
            buttonSort.Click += ButtonSort_Click;
            buttonFilter.Click += ButtonFilter_Click;
            buttonSave.Click += ButtonSave_Click;
            buttonLoad.Click += ButtonLoad_Click;
            buttonStatistics.Click += ButtonStatistics_Click;
            buttonChart.Click += ButtonChart_Click;

            // Поиск
            buttonSearchExecute.Click += ButtonSearchExecute_Click;
            buttonClearSearch.Click += ButtonClearSearch_Click;
            textBox1.KeyPress += TextBoxSearch_KeyPress;

            // Меню
            добавитьТоварToolStripMenuItem.Click += ButtonAddProduct_Click;
            редактироватьToolStripMenuItem.Click += ButtonEditProduct_Click;
            удалитьToolStripMenuItem.Click += ButtonDeleteProduct_Click;
            поискToolStripMenuItem.Click += ButtonSearch_Click;
            сортировкаToolStripMenuItem.Click += ButtonSort_Click;
            фильтрацияToolStripMenuItem.Click += ButtonFilter_Click;
            открытьToolStripMenuItem.Click += ButtonLoad_Click;
            сохранитьToolStripMenuItem.Click += ButtonSave_Click;
            статистикаToolStripMenuItem.Click += ButtonStatistics_Click;
            графикиToolStripMenuItem.Click += ButtonChart_Click;
            оПрограммеToolStripMenuItem.Click += ОПрограммеToolStripMenuItem_Click;
            руководствоToolStripMenuItem.Click += РуководствоToolStripMenuItem_Click;

            // Таблица
            dataGridViewProducts.CellDoubleClick += DataGridViewProducts_CellDoubleClick;

            // Форма
            this.Load += FormMain_Load;
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists(dataFilePath))
                {
                    products = LoadFromCSV(dataFilePath);
                    if (products.Count == 0)
                    {
                        LoadDefaultProducts();
                        SaveToCSV(dataFilePath);
                    }
                }
                else
                {
                    LoadDefaultProducts();
                    SaveToCSV(dataFilePath);
                }
                originalProducts = new List<Product>(products);
                isSorted = false;
                sortMode = -1;
                buttonSort.Text = "Сортировка";

                RefreshDataGridView();
                UpdateStatusBar($"Загружено {products.Count} записей");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadDefaultProducts();
                RefreshDataGridView();
            }
        }

        private void LoadDefaultProducts()
        {
            products.Clear();
            products.Add(new Product("001", "Молоко", 100, 85.50m, "Молоко 2.5%"));
            products.Add(new Product("002", "Хлеб", 50, 45.00m, "Хлеб белый"));
            products.Add(new Product("003", "Яйца", 200, 95.00m, "Яйца С0"));
            products.Add(new Product("004", "Сахар", 75, 65.00m, "Сахар 1кг"));
            products.Add(new Product("005", "Масло", 30, 120.00m, "Масло 82%"));
        }

        private List<Product> LoadFromCSV(string path)
        {
            var list = new List<Product>();

            try
            {
                if (!File.Exists(path)) return list;

                var lines = File.ReadAllLines(path, Encoding.UTF8);
                if (lines.Length < 2) return list;

                for (int i = 1; i < lines.Length; i++)
                {
                    var line = lines[i];
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var parts = ParseCSVLine(line);
                    if (parts.Length >= 5)
                    {
                        list.Add(new Product(
                            parts[0].Trim(),
                            parts[1].Trim(),
                            int.TryParse(parts[2], out int q) ? q : 0,
                            decimal.TryParse(parts[3], out decimal p) ? p : 0,
                            parts[4].Trim()
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка чтения файла: {ex.Message}", ex);
            }

            return list;
        }

        private string[] ParseCSVLine(string line)
        {
            var result = new List<string>();
            bool inQuotes = false;
            int startIndex = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '"')
                {
                    inQuotes = !inQuotes;
                }
                else if (line[i] == ',' && !inQuotes)
                {
                    result.Add(line.Substring(startIndex, i - startIndex).Trim('"'));
                    startIndex = i + 1;
                }
            }

            result.Add(line.Substring(startIndex).Trim('"'));
            return result.ToArray();
        }

        private void SaveToCSV(string path)
        {
            try
            {
                var lines = new List<string> { "Code,Name,Quantity,Price,Description" };

                foreach (var product in products)
                {
                    var line = $"{product.Code}," +
                               $"{EscapeCSVField(product.Name)}," +
                               $"{product.Quantity}," +
                               $"{product.Price:F2}," +
                               $"{EscapeCSVField(product.Description)}";
                    lines.Add(line);
                }

                File.WriteAllLines(path, lines, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка сохранения файла: {ex.Message}", ex);
            }
        }

        private string EscapeCSVField(string field)
        {
            if (string.IsNullOrEmpty(field)) return "";

            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n") || field.Contains("\r"))
            {
                return $"\"{field.Replace("\"", "\"\"")}\"";
            }

            return field;
        }

        private void RefreshDataGridView()
        {
            // Привязываем данные
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = products;


            UpdateStatusBar();
        }

        private void UpdateStatusBar(string status = "")
        {
            toolStripStatusLabelCount.Text = $"Записей: {products.Count}";
            toolStripStatusLabelData.Text = $"Дата: {DateTime.Now:dd.MM.yyyy}";

            if (!string.IsNullOrEmpty(status))
            {
                toolStripStatusLabelInfo.Text = status;
            }

            // Общая стоимость
            if (products.Count > 0)
            {
                decimal totalValue = products.Sum(p => p.Quantity * p.Price);
                toolStripStatusLabelInfo.Text += $" | Общая стоимость: {totalValue:C2}";
            }
        }

        private void SearchProducts(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                RefreshDataGridView();
                UpdateStatusBar("Поиск очищен");
                return;
            }

            var result = products.Where(p =>
                p.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                p.Code.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                p.Description.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();

            dataGridViewProducts.DataSource = result;
            UpdateStatusBar($"Найдено: {result.Count} товаров");
        }

        private void SortProducts()
        {
            if (products.Count == 0) return;

            try
            {
                if (isSorted && sortMode == 2)
                {
                    products = new List<Product>(originalProducts);
                    buttonSort.Text = "Сортировка";
                    UpdateStatusBar("Восстановлен исходный порядок");
                    isSorted = false;
                    sortMode = -1;
                }
                else
                {
                    int nextMode = (sortMode + 1) % 3;

                    switch (nextMode)
                    {
                        case 0: // По имени
                            products = products.OrderBy(p => p.Name).ToList();
                            buttonSort.Text = "Имя ";
                            UpdateStatusBar("Отсортировано по имени (А-Я)");
                            break;

                        case 1: // По количеству
                            products = products.OrderByDescending(p => p.Quantity).ToList();
                            buttonSort.Text = "Кол-во ";
                            UpdateStatusBar("Отсортировано по количеству (по убыванию)");
                            break;

                        case 2: // По цене
                            products = products.OrderByDescending(p => p.Price).ToList();
                            buttonSort.Text = "Цена ";
                            UpdateStatusBar("Отсортировано по цене (по убыванию)");
                            break;
                    }

                    sortMode = nextMode;
                    isSorted = true;
                }

                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сортировки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterProducts()
        {
            var filtered = dataService.FilterProductsByQuantityRange(products, 10, int.MaxValue);
            dataGridViewProducts.DataSource = filtered;
            UpdateStatusBar($"Отфильтровано: {filtered.Count} товаров (количество ≥ 10)");
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            using (var form = new FormAddEditProduct())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string code = dataService.GenerateNextProductCode(products);
                        var newProduct = new Product(
                            code,
                            form.ItemName,
                            form.ItemQuantity,
                            form.ItemPrice,
                            form.ItemDescription);

                        products.Add(newProduct);
                        originalProducts.Add(new Product(newProduct.Code, newProduct.Name, newProduct.Quantity, newProduct.Price, newProduct.Description));
                        isSorted = false;
                        sortMode = -1;
                        buttonSort.Text = "Сортировка";

                        SaveToCSV(dataFilePath);
                        RefreshDataGridView();
                        UpdateStatusBar("Товар добавлен");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка добавления товара: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ButtonEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для редактирования", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dataGridViewProducts.SelectedRows[0];
            var product = selectedRow.DataBoundItem as Product;

            if (product == null) return;

            using (var form = new FormAddEditProduct())
            {
                form.ItemName = product.Name;
                form.ItemQuantity = product.Quantity;
                form.ItemPrice = product.Price;
                form.ItemDescription = product.Description;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string originalCode = product.Code;
                        product.Name = form.ItemName;
                        product.Quantity = form.ItemQuantity;
                        product.Price = form.ItemPrice;
                        product.Description = form.ItemDescription;
                        product.Code = originalCode;
                        var originalProduct = originalProducts.FirstOrDefault(p => p.Code == originalCode);
                        if (originalProduct != null)
                        {
                            originalProduct.Name = form.ItemName;
                            originalProduct.Quantity = form.ItemQuantity;
                            originalProduct.Price = form.ItemPrice;
                            originalProduct.Description = form.ItemDescription;
                        }

                        isSorted = false;
                        sortMode = -1;
                        buttonSort.Text = "Сортировка";

                        SaveToCSV(dataFilePath);
                        RefreshDataGridView();
                        UpdateStatusBar("Товар изменён");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка редактирования товара: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для удаления", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dataGridViewProducts.SelectedRows[0];
            var product = selectedRow.DataBoundItem as Product;

            if (product == null) return;

            if (MessageBox.Show($"Удалить товар '{product.Name}'?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    products.Remove(product);
                    originalProducts.Remove(product);
                    isSorted = false;
                    sortMode = -1;
                    buttonSort.Text = "Сортировка";

                    SaveToCSV(dataFilePath);
                    RefreshDataGridView();
                    UpdateStatusBar("Товар удалён");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления товара: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void ButtonSearchExecute_Click(object sender, EventArgs e)
        {
            SearchProducts(textBox1.Text);
        }

        private void ButtonClearSearch_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            RefreshDataGridView();
            UpdateStatusBar("Поиск очищен");
        }

        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchProducts(textBox1.Text);
                e.Handled = true;
            }
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            SortProducts();
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveToCSV(dataFilePath);
                UpdateStatusBar("Данные сохранены в CSV");
                MessageBox.Show("Данные успешно сохранены", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ButtonStatistics_Click(object sender, EventArgs e)
        {
            if (products.Count == 0)
            {
                MessageBox.Show("Нет данных для статистики", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string stats = $"СТАТИСТИКА:\n" +
                           $"───────────\n" +
                           $"Товаров: {products.Count}\n" +
                           $"Всего на складе: {products.Sum(p => p.Quantity)} шт.\n" +
                           $"Общая стоимость: {products.Sum(p => p.Quantity * p.Price):C2}\n" +
                           $"───────────\n" +
                           $"Средняя цена: {products.Average(p => p.Price):C2}\n" +
                           $"Самый дорогой: {products.Max(p => p.Price):C2}\n" +
                           $"Самый дешевый: {products.Min(p => p.Price):C2}\n" +
                           $"───────────\n" +
                           $"Требуют пополнения (<10 шт.): {products.Count(p => p.Quantity < 10)}";

            MessageBox.Show(stats, "Статистика",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonChart_Click(object sender, EventArgs e)
        {
            if (products.Count == 0)
            {
                MessageBox.Show("Нет данных для графика", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Функция графика будет реализована в следующей версии", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ButtonEditProduct_Click(sender, e);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelInfo.Text = "Готово к работе";
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
     "Оптовая База v1.0\n" +
     "Автор: Завьялов Константин\n" +
     "Группа: РППБ-25-1\n\n" +
     "Программа для учета товаров на складе.",
     "О программе",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information
         );

        }
             private void РуководствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "РУКОВОДСТВО ПО ИСПОЛЬЗОВАНИЮ\n\n" +

                "Добавление: кнопка 'Добавить'\n" +
                "Редактирование: выберите товар → 'Редактировать'\n" +
                "Удаление: выберите товар → 'Удалить'\n" +
                "Поиск: введите текст → 'Найти'\n" +
                "Сортировка: кнопка 'Сортировка'\n" +
                "Фильтрация: кнопка 'Фильтр'\n" +
                "Сохранение: кнопка 'Сохранить'\n" +
                "Статистика: кнопка 'Статистика'\n\n" +

                "Данные сохраняются автоматически в CSV файл.",
                "Руководство",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}