namespace Tyuiu.ZavyalovKA.Sprint7.Task0.V5
{
    partial class FormAddEditProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            numericUpDownQuantity = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            textBoxDescription = new TextBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 80);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Название товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 348);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Описание:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 261);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Цена(руб):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 162);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Количество:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(183, 77);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(484, 23);
            textBoxName.TabIndex = 4;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(183, 160);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(100, 23);
            numericUpDownQuantity.TabIndex = 5;
            numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(183, 261);
            numericUpDownPrice.Maximum = new decimal(new int[] { 9999999, 0, 0, 65536 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(100, 23);
            numericUpDownPrice.TabIndex = 6;
            numericUpDownPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(183, 345);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(484, 29);
            textBoxDescription.TabIndex = 7;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(232, 414);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(80, 30);
            buttonOK.TabIndex = 8;
            buttonOK.Text = "ОК";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += new System.EventHandler(buttonOK_Click); // ДОБАВЬТЕ ЭТУ СТРОКУ
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(445, 414);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(80, 30);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += new System.EventHandler(buttonCancel_Click); // ДОБАВЬТЕ ЭТУ СТРОКУ
            // 
            // FormAddEditProduct
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(744, 476);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(textBoxDescription);
            Controls.Add(numericUpDownPrice);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddEditProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить / Редактировать товар";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownQuantity;
        private NumericUpDown numericUpDownPrice;
        private TextBox textBoxDescription;
        private Button buttonOK;
        private Button buttonCancel;
    }
}