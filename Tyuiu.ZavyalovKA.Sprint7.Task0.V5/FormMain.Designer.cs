namespace Tyuiu.ZavyalovKA.Sprint7.Task0.V5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            menuStripMain = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            товарыToolStripMenuItem = new ToolStripMenuItem();
            добавитьТоварToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            поискToolStripMenuItem = new ToolStripMenuItem();
            сортировкаToolStripMenuItem = new ToolStripMenuItem();
            фильтрацияToolStripMenuItem = new ToolStripMenuItem();
            отчётыToolStripMenuItem = new ToolStripMenuItem();
            статистикаToolStripMenuItem = new ToolStripMenuItem();
            графикиToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            руководствоToolStripMenuItem = new ToolStripMenuItem();
            panelToolbar = new Panel();
            buttonChart = new Button();
            buttonStatistics = new Button();
            buttonLoad = new Button();
            buttonSave = new Button();
            buttonFilter = new Button();
            buttonSort = new Button();
            buttonSearch = new Button();
            buttonDeleteProduct = new Button();
            buttonEditProduct = new Button();
            buttonAddProduct = new Button();
            panelSearch = new Panel();
            buttonClearSearch = new Button();
            buttonSearchExecute = new Button();
            textBox1 = new TextBox();
            labelSearch = new Label();
            dataGridViewProducts = new DataGridView();
            CodeColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            QuantityColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            DescriptionColumn = new DataGridViewTextBoxColumn();
            statusStripMain = new StatusStrip();
            toolStripStatusLabelInfo = new ToolStripStatusLabel();
            toolStripStatusLabelCount = new ToolStripStatusLabel();
            toolStripStatusLabelDate = new ToolStripStatusLabel();
            toolStripStatusLabelData = new ToolStripStatusLabel();
            menuStripMain.SuspendLayout();
            panelToolbar.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            statusStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, товарыToolStripMenuItem, отчётыToolStripMenuItem, справкаToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(1184, 24);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(133, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // товарыToolStripMenuItem
            // 
            товарыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьТоварToolStripMenuItem, редактироватьToolStripMenuItem, удалитьToolStripMenuItem, поискToolStripMenuItem, сортировкаToolStripMenuItem, фильтрацияToolStripMenuItem });
            товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            товарыToolStripMenuItem.Size = new Size(75, 20);
            товарыToolStripMenuItem.Text = "Операции";
            // 
            // добавитьТоварToolStripMenuItem
            // 
            добавитьТоварToolStripMenuItem.Name = "добавитьТоварToolStripMenuItem";
            добавитьТоварToolStripMenuItem.Size = new Size(160, 22);
            добавитьТоварToolStripMenuItem.Text = "Добавить товар";
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(160, 22);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(160, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(160, 22);
            поискToolStripMenuItem.Text = "Поиск";
            // 
            // сортировкаToolStripMenuItem
            // 
            сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            сортировкаToolStripMenuItem.Size = new Size(160, 22);
            сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // фильтрацияToolStripMenuItem
            // 
            фильтрацияToolStripMenuItem.Name = "фильтрацияToolStripMenuItem";
            фильтрацияToolStripMenuItem.Size = new Size(160, 22);
            фильтрацияToolStripMenuItem.Text = "Фильтрация";
            // 
            // отчётыToolStripMenuItem
            // 
            отчётыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { статистикаToolStripMenuItem, графикиToolStripMenuItem });
            отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            отчётыToolStripMenuItem.Size = new Size(60, 20);
            отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // статистикаToolStripMenuItem
            // 
            статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            статистикаToolStripMenuItem.Size = new Size(135, 22);
            статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // графикиToolStripMenuItem
            // 
            графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            графикиToolStripMenuItem.Size = new Size(135, 22);
            графикиToolStripMenuItem.Text = "График";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, руководствоToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // руководствоToolStripMenuItem
            // 
            руководствоToolStripMenuItem.Name = "руководствоToolStripMenuItem";
            руководствоToolStripMenuItem.Size = new Size(149, 22);
            руководствоToolStripMenuItem.Text = "Руководство";
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.Gainsboro;
            panelToolbar.BorderStyle = BorderStyle.FixedSingle;
            panelToolbar.Controls.Add(buttonChart);
            panelToolbar.Controls.Add(buttonStatistics);
            panelToolbar.Controls.Add(buttonLoad);
            panelToolbar.Controls.Add(buttonSave);
            panelToolbar.Controls.Add(buttonFilter);
            panelToolbar.Controls.Add(buttonSort);
            panelToolbar.Controls.Add(buttonSearch);
            panelToolbar.Controls.Add(buttonDeleteProduct);
            panelToolbar.Controls.Add(buttonEditProduct);
            panelToolbar.Controls.Add(buttonAddProduct);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 24);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1184, 50); 
            panelToolbar.TabIndex = 1;
            // 
            // buttonChart
            // 
            buttonChart.FlatStyle = FlatStyle.Flat;
            buttonChart.Location = new Point(1046, 10); 
            buttonChart.Name = "buttonChart";
            buttonChart.Size = new Size(100, 30); 
            buttonChart.TabIndex = 9;
            buttonChart.Text = "График";
            buttonChart.UseVisualStyleBackColor = true;
            // 
            // buttonStatistics
            // 
            buttonStatistics.FlatStyle = FlatStyle.Flat;
            buttonStatistics.Location = new Point(917, 10); 
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Size = new Size(100, 30); 
            buttonStatistics.TabIndex = 8;
            buttonStatistics.Text = "Статистика";
            buttonStatistics.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            buttonLoad.FlatStyle = FlatStyle.Flat;
            buttonLoad.Location = new Point(794, 10); 
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(100, 30); 
            buttonLoad.TabIndex = 7;
            buttonLoad.Text = "Загрузить";
            buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(678, 10); 
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 30); 
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            buttonFilter.FlatStyle = FlatStyle.Flat;
            buttonFilter.Location = new Point(562, 10); 
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(100, 30); 
            buttonFilter.TabIndex = 5;
            buttonFilter.Text = "Фильтр";
            buttonFilter.UseVisualStyleBackColor = true;
            // 
            // buttonSort
            // 
            buttonSort.FlatStyle = FlatStyle.Flat;
            buttonSort.Location = new Point(443, 10); 
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(100, 30); 
            buttonSort.TabIndex = 4;
            buttonSort.Text = "Сортировка";
            buttonSort.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Location = new Point(339, 10); 
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(100, 30); 
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.FlatStyle = FlatStyle.Flat;
            buttonDeleteProduct.Location = new Point(239, 10); 
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(100, 30); 
            buttonDeleteProduct.TabIndex = 2;
            buttonDeleteProduct.Text = "Удалить";
            buttonDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // buttonEditProduct
            // 
            buttonEditProduct.FlatStyle = FlatStyle.Flat;
            buttonEditProduct.Location = new Point(117, 10); 
            buttonEditProduct.Name = "buttonEditProduct";
            buttonEditProduct.Size = new Size(100, 30); 
            buttonEditProduct.TabIndex = 1;
            buttonEditProduct.Text = "Редактировать";
            buttonEditProduct.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.FlatStyle = FlatStyle.Flat;
            buttonAddProduct.Location = new Point(11, 10); 
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(100, 30); 
            buttonAddProduct.TabIndex = 0;
            buttonAddProduct.Text = "Добавить";
            buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.WhiteSmoke;
            panelSearch.Controls.Add(buttonClearSearch);
            panelSearch.Controls.Add(buttonSearchExecute);
            panelSearch.Controls.Add(textBox1);
            panelSearch.Controls.Add(labelSearch);
            panelSearch.Dock = DockStyle.Top; 
            panelSearch.Location = new Point(0, 74); 
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1184, 35);
            panelSearch.TabIndex = 2;
            // 
            // buttonClearSearch
            // 
            buttonClearSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClearSearch.Location = new Point(1090, 4); 
            buttonClearSearch.Name = "buttonClearSearch";
            buttonClearSearch.Size = new Size(80, 28);
            buttonClearSearch.TabIndex = 3;
            buttonClearSearch.Text = "Сброс";
            buttonClearSearch.UseVisualStyleBackColor = true;
            // 
            // buttonSearchExecute
            // 
            buttonSearchExecute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearchExecute.Location = new Point(1000, 4); 
            buttonSearchExecute.Name = "buttonSearchExecute";
            buttonSearchExecute.Size = new Size(80, 28);
            buttonSearchExecute.TabIndex = 2;
            buttonSearchExecute.Text = "Найти";
            buttonSearchExecute.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(120, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(874, 23); 
            textBox1.TabIndex = 1;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(25, 9);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(42, 15);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "Поиск";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; 
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { CodeColumn, NameColumn, QuantityColumn, PriceColumn, DescriptionColumn });
            dataGridViewProducts.Location = new Point(0, 109); 
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersWidth = 50;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(1184, 430); 
            dataGridViewProducts.TabIndex = 3;
            // 
            // CodeColumn
            // 
            CodeColumn.Frozen = true;
            CodeColumn.HeaderText = "Код";
            CodeColumn.Name = "CodeColumn";
            CodeColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameColumn.HeaderText = "Название товара";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            QuantityColumn.DefaultCellStyle = dataGridViewCellStyle3;
            QuantityColumn.HeaderText = "Количество";
            QuantityColumn.Name = "QuantityColumn";
            QuantityColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            PriceColumn.DefaultCellStyle = dataGridViewCellStyle4;
            PriceColumn.HeaderText = "Цена(руб)";
            PriceColumn.Name = "PriceColumn";
            PriceColumn.ReadOnly = true;
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.HeaderText = "Описание";
            DescriptionColumn.Name = "DescriptionColumn";
            DescriptionColumn.ReadOnly = true;
            DescriptionColumn.Width = 400; 
            // 
            // statusStripMain
            // 
            statusStripMain.BackColor = SystemColors.ControlLight;
            statusStripMain.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo, toolStripStatusLabelCount, toolStripStatusLabelDate, toolStripStatusLabelData });
            statusStripMain.Location = new Point(0, 539);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(1184, 22);
            statusStripMain.TabIndex = 4;
            statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelInfo
            // 
            toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            toolStripStatusLabelInfo.Size = new Size(1069, 17);
            toolStripStatusLabelInfo.Spring = true;
            toolStripStatusLabelInfo.Text = "Готово";
            // 
            // toolStripStatusLabelCount
            // 
            toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            toolStripStatusLabelCount.Size = new Size(65, 17);
            toolStripStatusLabelCount.Text = "Записей: 0";
            // 
            // toolStripStatusLabelDate
            // 
            toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            toolStripStatusLabelDate.Size = new Size(0, 17);
            // 
            // toolStripStatusLabelData
            // 
            toolStripStatusLabelData.Name = "toolStripStatusLabelData";
            toolStripStatusLabelData.Size = new Size(35, 17);
            toolStripStatusLabelData.Text = "Дата:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(statusStripMain);
            Controls.Add(dataGridViewProducts);
            Controls.Add(panelSearch);
            Controls.Add(panelToolbar);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            MinimumSize = new Size(1000, 600); 
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оптовая База";
            Load += FormMain_Load; 
            Resize += FormMain_Resize;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            panelToolbar.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem товарыToolStripMenuItem;
        private ToolStripMenuItem добавитьТоварToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem отчётыToolStripMenuItem;
        private ToolStripMenuItem статистикаToolStripMenuItem;
        private ToolStripMenuItem графикиToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem руководствоToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripMenuItem сортировкаToolStripMenuItem;
        private ToolStripMenuItem фильтрацияToolStripMenuItem;
        private Panel panelToolbar;
        private Button buttonChart;
        private Button buttonStatistics;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonFilter;
        private Button buttonSort;
        private Button buttonSearch;
        private Button buttonDeleteProduct;
        private Button buttonEditProduct;
        private Button buttonAddProduct;
        private Panel panelSearch;
        private TextBox textBox1;
        private Label labelSearch;
        private Button buttonClearSearch;
        private Button buttonSearchExecute;
        private DataGridView dataGridViewProducts;
        private DataGridViewTextBoxColumn CodeColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn QuantityColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel toolStripStatusLabelInfo;
        private ToolStripStatusLabel toolStripStatusLabelCount;
        private ToolStripStatusLabel toolStripStatusLabelDate;
        private ToolStripStatusLabel toolStripStatusLabelData;
    }
}