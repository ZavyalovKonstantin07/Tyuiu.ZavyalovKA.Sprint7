using System;

using System.Windows.Forms;

namespace Tyuiu.ZavyalovKA.Sprint7.Task0.V5
{
    public partial class FormAddEditProduct : Form
    {
        // УБРАТЬ эти свойства - они конфликтуют с унаследованными
        // public string ProductName { get; set; }
        // public int Quantity { get; set; }
        // public decimal Price { get; set; }
        // public string Description { get; set; }

        // Вместо этого используем новые имена:
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemPrice { get; set; }
        public string ItemDescription { get; set; }

        public FormAddEditProduct()
        {
            InitializeComponent();
        }

        private void FormAddEditProduct_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ItemName))
            {
                if (Controls.ContainsKey("textBoxName"))
                {
                    (Controls["textBoxName"] as TextBox).Text = ItemName;
                }
                if (Controls.ContainsKey("numericUpDownQuantity"))
                {
                    (Controls["numericUpDownQuantity"] as NumericUpDown).Value = ItemQuantity;
                }
                if (Controls.ContainsKey("numericUpDownPrice"))
                {
                    (Controls["numericUpDownPrice"] as NumericUpDown).Value = ItemPrice;
                }
                if (Controls.ContainsKey("textBoxDescription"))
                {
                    (Controls["textBoxDescription"] as TextBox).Text = ItemDescription;
                }
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            TextBox txtName = null;
            NumericUpDown numQuantity = null;
            NumericUpDown numPrice = null;
            TextBox txtDescription = null;
            foreach (Control control in Controls)
            {
                if (control.Name == "textBoxName") txtName = control as TextBox;
                if (control.Name == "numericUpDownQuantity") numQuantity = control as NumericUpDown;
                if (control.Name == "numericUpDownPrice") numPrice = control as NumericUpDown;
                if (control.Name == "textBoxDescription") txtDescription = control as TextBox;
            }
            if (txtName == null || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название товара", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtName != null) txtName.Focus();
                return;
            }
            ItemName = txtName.Text.Trim();
            ItemQuantity = numQuantity != null ? (int)numQuantity.Value : 0;
            ItemPrice = numPrice != null ? numPrice.Value : 0;
            ItemDescription = txtDescription != null ? txtDescription.Text.Trim() : "";

            DialogResult = DialogResult.OK;
            Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}