using System;

using System.Windows.Forms;

namespace Tyuiu.ZavyalovKA.Sprint7.Task0.V5
{
    public partial class FormAddEditProduct : Form
    {
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemPrice { get; set; }
        public string ItemDescription { get; set; }

        public FormAddEditProduct()
        {
            InitializeComponent();
            foreach (Control control in Controls)
            {
                if (control is Button btn && (btn.Name == "buttonOK" || btn.Text == "OK"))
                {
                    btn.Enabled = true;
                    this.AcceptButton = btn; 
                    break;
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string name = "";
            int quantity = 10;
            decimal price = 100.00m;
            string description = "";
            foreach (Control control in Controls)
            {
                if (control.Name == "textBoxName" && control is TextBox txt)
                    name = txt.Text;
                else if (control.Name == "numericUpDownQuantity" && control is NumericUpDown numQ)
                    quantity = (int)numQ.Value;
                else if (control.Name == "numericUpDownPrice" && control is NumericUpDown numP)
                    price = numP.Value;
                else if (control.Name == "textBoxDescription" && control is TextBox txtD)
                    description = txtD.Text;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название товара", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ItemName = name;
            ItemQuantity = quantity;
            ItemPrice = price;
            ItemDescription = description;
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